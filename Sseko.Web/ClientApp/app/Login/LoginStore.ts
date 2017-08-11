import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import axios from 'axios';

export interface AuthState {
    error: string;
    message: string;
    content: string;
    authenticated: boolean;
}

interface AuthUserAction { type: 'AUTH_USER' }
interface UnAuthUserAction { type: 'UNAUTH_USER' }
interface AuthErrorAction { type: 'AUTH_ERROR', payload: '' }

type KnownAction = AuthUserAction | UnAuthUserAction | AuthErrorAction;

export const actionCreators = {

    errorHandler: (dispatch, error, type) => {
        let errorMessage = '';

        errorMessage = error;

        if (error.status === 401) {
            dispatch({
                type: type,
                payload: 'Invalid username or password'
            });
        } else {
            dispatch({
                type: type,
                payload: 'Server error. Please try again'
            });
        }
    },

    loginUser: (email, password): AppThunkAction<KnownAction> => (dispatch, getState) => {
        axios.post(`/api/users/login`, { username: email, password })
            .then(response => {
                const cookies = new Cookies();
                cookies.set('token', response.data.token, { path: '/' });
                var decodedToken = Decoder(response.data.token);

                dispatch({ type: 'AUTH_USER'});
                window.location.href = '/';
            })
            .catch((error) => {
                this.actionCreators.errorHandler(dispatch, error.response, 'AUTH_ERROR')
            });
    }
}

const unloadedState: AuthState = { error: '', message: '', content: '', authenticated: false };

export const reducer: Reducer<AuthState> = (state: AuthState, action: KnownAction) => {
    switch (action.type) {
        case 'AUTH_USER':
            return { ...state, error: '', message: '', authenticated: true };
        case 'UNAUTH_USER':
            return { ...state, authenticated: false };
        case 'AUTH_ERROR':
            return { ...state, error: action.payload };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}