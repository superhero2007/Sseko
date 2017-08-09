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
    role: string;
}

interface AuthUserAction { type: 'AUTH_USER', role: '' }
interface UnAuthUserAction { type: 'UNAUTH_USER' }
interface AuthErrorAction { type: 'AUTH_ERROR', payload: '' }
interface ProtectedTestAction { type: 'PROTECTED_TEST', payload: '' }

type KnownAction = AuthUserAction | UnAuthUserAction | AuthErrorAction | ProtectedTestAction;

export const actionCreators = {

    errorHandler: (dispatch, error, type) => {
        let errorMessage = '';

        errorMessage = error;

        if (error.status === 401) {
            dispatch({
                type: type,
                payload: 'You are not authorized to do this. Please login and try again.'
            });
            this.logoutUser();
        } else {
            dispatch({
                type: type,
                payload: errorMessage
            });
        }
    },

    loginUser: (email, password): AppThunkAction<KnownAction> => (dispatch, getState) => {
        axios.post(`/auth/login`, { email, password })
            .then(response => {
                const cookies = new Cookies();
                cookies.set('token', response.data.token, { path: '/' });
                var decodedToken = Decoder(response.data.token);

                dispatch({ type: 'AUTH_USER', role: decodedToken.role });
                window.location.href = '/';
            })
            .catch((error) => {
                this.actionCreators.errorHandler(dispatch, error.message, 'AUTH_ERROR')
            });
    },

    logoutUser: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UNAUTH_USER' });
        const cookies = new Cookies();
        cookies.remove('token', { path: '/' });

        window.location.href = '/login';
    },

    protectedTest: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        const cookies = new Cookies();
        axios.get(`auth/protected`, {
            headers: { 'Authorization': cookies.load('token') }
        })
            .then(response => {
                dispatch({
                    type: 'PROTECTED_TEST',
                    payload: response.data.content
                });
            })
            .catch((error) => {
                this.errorHandler(dispatch, error.response, 'AUTH_ERROR')
            });
    },
}

const unloadedState: AuthState = { error: '', message: '', content: '', authenticated: false, role: '' };

export const reducer: Reducer<AuthState> = (state: AuthState, action: KnownAction) => {
    switch (action.type) {
        case 'AUTH_USER':
            return { ...state, error: '', message: '', authenticated: true, role: action.role };
        case 'UNAUTH_USER':
            return { ...state, authenticated: false };
        case 'AUTH_ERROR':
            return { ...state, error: action.payload };
        case 'PROTECTED_TEST':
            return { ...state, content: action.payload };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}