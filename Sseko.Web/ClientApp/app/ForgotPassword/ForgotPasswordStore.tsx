import axios from 'axios';
import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from '../../store';

export interface ForgotPasswordState {
    submitted: boolean
}

interface SubmitPasswordRequest { type: 'SUBMIT_RESET_REQUEST' };

type KnownAction = SubmitPasswordRequest;

export const actionCreators = {
    submitRequest: (email: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var cookies = new Cookies();
        axios.post('/api/users/resetPassword', { email })
            .then(response => {
                dispatch({ type: 'SUBMIT_RESET_REQUEST' });
            })
            .catch((error) => {

            });
    }
}

const unloadedState: ForgotPasswordState = {
    submitted: false
}

export const reducer: Reducer<ForgotPasswordState> = (state: ForgotPasswordState, action: KnownAction) => {
    switch (action.type) {
        case 'SUBMIT_RESET_REQUEST':
            return { ...state, errors: '', submitted: true };
        //Uncomment this code if another action is ever added.
        //default:
        //    const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}