import * as api from '../../api';
import * as Cookies from 'universal-cookie';
import * as dtos from '../../dtos';
import { AppThunkAction } from '../../store';
import { Action, Reducer, ActionCreator } from 'redux';
import { RowHelpers } from '../../components/DataTable/RowHelpers';
import ManageUsersState from '../../store/ManageUsersState';

interface GetUserList { type: 'GET_USER_LIST', payload: dtos.UserDto[] }
interface UpdateSort { type: 'UPDATE_USER_SORT', column: string, direction: string }

type KnownAction = GetUserList | UpdateSort;

export const actionCreators = {

    getUsers: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Users.Get()
            .then((response) => {
                dispatch({ type: 'GET_USER_LIST', payload: response.data });
            })
            .catch((error) => {
            });
    },

    impersonate: (userToImpersonateId: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Account.ImpersonateUser(userToImpersonateId)
            .then(response => {
                const cookies = new Cookies();
                cookies.set('token', response.data.token, { path: '/' });

                window.location.href = '/';
            })
            .catch(error => {

            });
    },

    toggleEnable: (id: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var rows = getState().users.rows;

        var newRows = RowHelpers.toggleEnabled(rows, id);

        dispatch({ type: 'GET_USER_LIST', payload: newRows });

        api.Users.ToggleEnabled(id)
            .then(response => {

            })
            .catch(error => {
                dispatch({ type: 'GET_USER_LIST', payload: rows });
            })
    },

    resetPassword: (id: string): AppThunkAction<KnownAction> => (dispatch, getState) => {

    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_USER_SORT', column, direction });
    }
}

const unloadedState: ManageUsersState = {
    rows: [],
    sortColumn: 'username',
    sortDirection: 'ASC',
    loading: true
}

export const reducer: Reducer<ManageUsersState> = (state: ManageUsersState, incomingAction: Action) => {
    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'GET_USER_LIST':
            return { ...state, error: '', rows: action.payload, loading: false };
        case 'UPDATE_USER_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}
