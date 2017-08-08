import axios from 'axios';
import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from './';

export interface PvReportState {
    rows: PvRow[],
    sortColumn: string,
    sortDirection: string,
    errors: string
}

interface GetPvRows { type: 'GET_PV_ROWS', payload: PvRow[] }
interface UpdateSort { type: 'UPDATE_SORT', column: string, direction: string }

type KnownAction = GetPvRows | UpdateSort;

export const actionCreators = {
    getPvReport: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var cookies = new Cookies();
        axios.get('/api/reports/personalvolume', { headers: { Authorization: "Bearer " + cookies.get("token") } })
            .then(response => {
                dispatch({ type: 'GET_PV_ROWS', payload: response.data });
            })
            .catch((error) => {

            });
    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_SORT', column, direction })
    }
}

const unloadedState: PvReportState = {
    rows: [],
    errors: '',
    sortColumn: 'date',
    sortDirection: 'ASC'
}

export const reducer: Reducer<PvReportState> = (state: PvReportState, action: KnownAction) => {
    switch (action.type) {
        case 'GET_PV_ROWS':
            return { ...state, errors: '', rows: action.payload };
        case 'UPDATE_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

export interface PvRow {
    date: string,
    orderNumber: string,
    customer: string,
    hostess: string,
    type: string,
    commission: string,
    sale: string
}