import * as api from '../../api';
import * as dtos from '../../dtos';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import DlReportState from '../../store/DlReportState';

interface GetDlRows { type: 'GET_DL_ROWS', payload: dtos.ReportForDownlineDto[] }
interface UpdateLevelFilter { type: 'UPDATE_LEVEL_FILTER', payload: string[] }
interface UpdateSort { type: 'UPDATE_DL_SORT', column: string, direction: string }

type KnownAction = GetDlRows | UpdateLevelFilter | UpdateSort;

export const actionCreators = {
    getDlReport: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Reports.Downline()
            .then(response => {
                dispatch({ type: 'GET_DL_ROWS', payload: response.data });
            })
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
    sortDirection: 'ASC',
    loading: true
}

export const reducer: Reducer<DlReportState> = (state: DlReportState, action: KnownAction) => {
    switch (action.type) {
        case 'GET_DL_ROWS':
            return { ...state, errors: '', rows: action.payload, loading: false };
        case 'UPDATE_LEVEL_FILTER':
            return { ...state, levelFilter: action.payload };
        case 'UPDATE_DL_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

