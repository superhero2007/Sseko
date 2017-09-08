import axios from 'axios';
import { Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from '../../store';

export interface ManageUserState {
    rows: User[],
    loading: boolean,
    sortColumn: string,
    sortDirection: string,
    error: string
}

interface UserManagerError { type: 'USER_MANAGER_ERROR', error: any }
interface GetUserList { type: 'GET_USER_LIST', payload: User[] }
interface UpdateSort { type: 'UPDATE_USER_SORT', column: string, direction: string }

type KnownAction = GetUserList | UserManagerError | UpdateSort;

export const actionCreators = {
    errorHandler: (dispatch, error, type) => {
        let errorMessage = '';

        errorMessage = error;

        if (error.status === 401) {
            dispatch({
                type: type,
                error: 'Unauthorized!'
            });
        } else {
            dispatch({
                type: type,
                error: 'Server error. Please try again'
            });
        }
    },

    getUsers: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var cookies = new Cookies();
        axios.get('/api/users/', { headers: { Authorization: "Bearer " + cookies.get("token") } })
            .then((response) => {
                dispatch({ type: 'GET_USER_LIST', payload: response.data });
            })
            .catch((error) => {
                this.actionCreators.errorHandler(dispatch({ type: 'USER_MANAGER_ERROR', error: error.resposne }));
            });
    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_USER_SORT', column, direction });
    }
}

const unloadedState: ManageUserState = {
    rows: [],
    error: '',
    sortColumn: 'username',
    sortDirection: 'ASC',
    loading: true
}

export const reducer: Reducer<ManageUserState> = (state: ManageUserState, action: KnownAction) => {
    switch (action.type) {
        case 'GET_USER_LIST':
            return { ...state, error: '', rows: action.payload, loading: false };
        case 'USER_MANAGER_ERROR':
            return { ...state, error: action.error, loading: false }
        case 'UPDATE_USER_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

interface User {
    username: string,
    role: string
}