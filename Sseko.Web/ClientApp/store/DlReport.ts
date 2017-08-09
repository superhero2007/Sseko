import axios from 'axios';
import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from './';

export interface DlReportState {
    rows: DlRow[],
    sortColumn: string,
    sortDirection: string,
    levelFilter: string[],
    errors: string
}

interface GetDlRows { type: 'GET_DL_ROWS', payload: DlRow[] }
interface UpdateLevelFilter { type: 'UPDATE_LEVEL_FILTER', payload: string[] }
interface UpdateSort { type: 'UPDATE_DL_SORT', column: string, direction: string }

type KnownAction = GetDlRows | UpdateLevelFilter | UpdateSort;

export const actionCreators = {
    getDlReport: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        var cookies = new Cookies();
        axios.get('/api/reports/downline', { headers: { Authorization: "Bearer " + cookies.get("token") } })
            .then(response => {
                dispatch({ type: 'GET_DL_ROWS', payload: response.data });
            })
            .catch((error) => {

            });
    },

    updateLevelFilter: (levelFilter: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_LEVEL_FILTER', payload: levelFilter });
    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_DL_SORT', column, direction })
    }
}

const unloadedState: DlReportState = {
    rows: [],
    errors: '',
    levelFilter: ["1", "2", "3"],
    sortColumn: 'fellow',
    sortDirection: 'ASC'
}

export const reducer: Reducer<DlReportState> = (state: DlReportState, action: KnownAction) => {
    switch (action.type) {
        case 'GET_DL_ROWS':
            return { ...state, errors: '', rows: action.payload };
        case 'UPDATE_LEVEL_FILTER':
            return { ...state, levelFilter: action.payload };
        case 'UPDATE_DL_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

export interface DlRow {
    name: string,
    parent: string,
    grandparent: string,
    level: string,
    commissionableSales: string,
    totalSales: string,
}