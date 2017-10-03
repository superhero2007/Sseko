import * as api from '../../api';
import * as dtos from '../../dtos';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import DlReportState from '../../store/DlReportState';
import * as moment from 'moment';

interface GetDlRowsInit { type: 'GET_DL_ROWS_INIT'}
interface GetDlRows { type: 'GET_DL_ROWS', payload: dtos.ReportForDownlineDto[] }
interface UpdateLevelFilter { type: 'UPDATE_LEVEL_FILTER', payload: string[] }
interface UpdateSort { type: 'UPDATE_PV_SORT', column: string, direction: string }
interface UpdateHostessFilter { type: 'UPDATE_HOSTESS_FILTER', hostessFilter: string[] }
interface UpdateDateFilter { type: 'UPDATE_DATE_FILTER', startDate: Date, endDate: Date }

type KnownAction = GetDlRows | UpdateLevelFilter | UpdateSort | UpdateHostessFilter | UpdateDateFilter | GetDlRowsInit;

export const actionCreators = {
    getDlReport: (startDate, endDate): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Reports.Downline(startDate, endDate)
            .then(response => {
                dispatch({ type: 'GET_DL_ROWS', payload: response.data });
            })
    },

    updateLevelFilter: (levelFilter: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_LEVEL_FILTER', payload: levelFilter });
    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_PV_SORT', column, direction })
    },

    updateHostessFilter: (hostessFilter: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_HOSTESS_FILTER', hostessFilter });
    },

    updateDateFilter: (startDate: Date, endDate: Date): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_DATE_FILTER', startDate, endDate })
        dispatch({ type: 'GET_DL_ROWS_INIT' });
        api.Reports.Downline(startDate, endDate)
            .then(response => {
                dispatch({ type: 'GET_DL_ROWS', payload: response.data });
            })
    }
}

const unloadedState: DlReportState = {
    rows: [],
    errors: '',
    levelFilter: ["1", "2", "3"],
    sortColumn: 'fellow',
    sortDirection: 'ASC',
    startDate: moment().add(-1, 'year'),
    endDate: moment(),
    loading: true,
    hostessFilter: []
}

export const reducer: Reducer<DlReportState> = (state: DlReportState, incomingAction: Action) => {
    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'GET_DL_ROWS_INIT':
            return { ...state, errors: '', rows: [], loading: true };
        case 'GET_DL_ROWS':
            return { ...state, errors: '', loading: false, rows: action.payload};
        case 'UPDATE_LEVEL_FILTER':
            return { ...state, levelFilter: action.payload };
        case 'UPDATE_PV_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        case 'UPDATE_HOSTESS_FILTER':
            return { ...state, hostessFilter: action.hostessFilter };
        case 'UPDATE_DATE_FILTER':
            return { ...state, startDate: action.startDate, endDate: action.endDate };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

