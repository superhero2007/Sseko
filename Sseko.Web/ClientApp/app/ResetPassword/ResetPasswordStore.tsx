import axios from 'axios';
import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from '../../store';

export interface ResetPasswordState {
    submitted: boolean,
    error: string
}

interface ResetPasswordError { type: 'RESET_PASSWORD_ERROR', error: any }
interface ResetPassword { type: 'RESET_PASSWORD' };

type KnownAction = ResetPassword | ResetPasswordError;

export const actionCreators = {
    errorHandler: (dispatch, error) => {

        dispatch({
            type: 'RESET_PASSWORD_ERROR',
            error: 'Server error. Please try again'
        });
    },

    submitRequest: (password: string, code: string): AppThunkAction<KnownAction> => async (dispatch, getState) => {
        var cookies = new Cookies();
        var valid = await axios.post('/api/users/verifycode', { code })
            .then(response => {
                return true;
            })
            .catch(error => {
                this.actionCreators.errorHandler(dispatch, error.response)
                return false;
            });

        axios.post('/api/users/resetPassword', { password })
            .then(response => {
                if (valid)
                    dispatch({ type: 'RESET_PASSWORD' });
            })
            .catch((error) => {
                this.actionCreators.errorHandler(dispatch, error.response)
    });
    }
}

const unloadedState: ResetPasswordState = {
    submitted: false,
    error: ''
}

export const reducer: Reducer<ResetPasswordState> = (state: ResetPasswordState, action: KnownAction) => {
    switch (action.type) {
        case 'RESET_PASSWORD':
            return { ...state, error: '', submitted: true };
        case 'RESET_PASSWORD_ERROR':
            return { ...state, error: action.error, submitted: false }
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}