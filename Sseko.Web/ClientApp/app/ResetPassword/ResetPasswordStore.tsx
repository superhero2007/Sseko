import axios from 'axios';
import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from '../../store';

export interface ResetPasswordState {
    submitted: boolean,
    email: string,
    error: string
}

interface ResetPasswordError { type: 'RESET_PASSWORD_ERROR', error: any }
interface ResetPassword { type: 'RESET_PASSWORD' };
interface VerifiedCode { type: 'CODE_IS_VERIFIED', email: string }

type KnownAction = ResetPassword | ResetPasswordError | VerifiedCode;

export const actionCreators = {
    errorHandler: (dispatch, error) => {

        dispatch({
            type: 'RESET_PASSWORD_ERROR',
            error: 'Server error. Please try again'
        });
    },

    getEmail: (code: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var valid = axios.post('/api/users/verifyresetlink', { code })
            .then(response => {
                dispatch({ type: 'CODE_IS_VERIFIED', email: response.data.email })
            })
            .catch(error => {
                this.actionCreators.errorHandler(dispatch, error.response)
            });
    },

    submitRequest: (email: string, password: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var cookies = new Cookies();

        axios.post('/api/users/resetPassword', { email, password })
            .then(response => {
                dispatch({ type: 'RESET_PASSWORD' });
            })
            .catch((error) => {
                this.actionCreators.errorHandler(dispatch, error.response)
            });
    }
}

const unloadedState: ResetPasswordState = {
    submitted: false,
    error: '',
    email: ''
}

export const reducer: Reducer<ResetPasswordState> = (state: ResetPasswordState, action: KnownAction) => {
    switch (action.type) {
        case 'RESET_PASSWORD':
            return { ...state, error: '', submitted: true };
        case 'RESET_PASSWORD_ERROR':
            return { ...state, error: action.error, submitted: false }
        case 'CODE_IS_VERIFIED':
            return { ...state, error: '', email: action.email, submitted: false }
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}