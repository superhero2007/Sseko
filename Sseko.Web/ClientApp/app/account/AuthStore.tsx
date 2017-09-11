import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import Decoder from 'jwt-decode';
import { AppThunkAction } from '../../store';
import AuthState from '../../store/AuthState';
import * as api from '../../api';
import * as dtos from '../../dtos';

interface SubmitPasswordRequest { type: 'SUBMIT_RESET_REQUEST' };
interface ResetPasswordError { type: 'RESET_PASSWORD_ERROR', error: any }
interface ResetPassword { type: 'RESET_PASSWORD' };
interface VerifiedCode { type: 'CODE_IS_VERIFIED', email: string }
interface AuthUser { type: 'AUTH_USER' }

type KnownAction = SubmitPasswordRequest | ResetPasswordError | ResetPassword | VerifiedCode;

export const actionCreators = {

    loginUser: (user: dtos.UserForAuthDto): AppThunkAction<KnownAction> => (dispatch, getState) => {

        api.Account.Login(user)
            .then(response => {
                const cookies = new Cookies();
                cookies.set('token', response.data.token, { path: '/' });

                window.location.href = '/';
            })
            .catch((error) => {
            });
    },

    sendResetLink: (email: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Account.SendPasswordResetLink(email)
            .then(response => {
                dispatch({ type: 'SUBMIT_RESET_REQUEST' });
            })
    },

    getEmail: (code: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Account.VerifyResetLink(code).then(response => {
            dispatch({ type: 'CODE_IS_VERIFIED', email: response.data.email })
        })
            .catch(error => {
            });
    },

    resetPassword: (user: dtos.UserForPasswordResetDto): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Account.ResetForgottenPassword(user).then(response => {
            dispatch({ type: 'RESET_PASSWORD' });
        })
            .catch((error) => {
            });
    }
}

const unloadedState: AuthState = {
    resetPasswordLinkSent: false,
    passwordResetFormSent: false,
    error: '',
    email: ''
}

export const reducer: Reducer<AuthState> = (state: AuthState, action: KnownAction) => {
    switch (action.type) {
        case 'SUBMIT_RESET_REQUEST':
            return { ...state, resetPasswordLinkSent: true };
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