import * as dtos from '../../dtos';
import * as api from '../../api';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import DashboardState from '../../store/DashboardState';
import * as moment from 'moment';

interface GetDashboardModel { type: 'GET_DASHBOARD_MODEL', payload: any }
interface GetPvRows { type: 'GET_PV_ROWS', payload: dtos.ReportForPersonalVolumeDto[] }
interface UpdateSort { type: 'UPDATE_PV_SORT', column: string, direction: string }
interface UpdateSaleTypeFilter { type: 'UPDATE_SALE_FILTER', saleTypeFilter: string[] }
interface UpdateHostessFilter { type: 'UPDATE_HOSTESS_FILTER', hostessFilter: string[] }
interface UpdateDateFilter { type: 'UPDATE_DATE_FILTER', startDate: moment.Moment, endDate: moment.Moment }

type KnownAction = GetDashboardModel | GetPvRows | UpdateSort | UpdateSaleTypeFilter | UpdateHostessFilter | UpdateDateFilter;

export const actionCreators = {
    getPvReport: (): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Reports.PersonalVolume()
            .then(response => {
                dispatch({ type: 'GET_PV_ROWS', payload: response.data });
            })
            .catch((error) => {
            });
    },

    updateSaleFilter: (saleTypes: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_SALE_FILTER', saleTypeFilter: saleTypes });
    },

    updateHostessFilter: (hostessFilter: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_HOSTESS_FILTER', hostessFilter });
    },

    updateDateFilter: (startDate: moment.Moment, endDate: moment.Moment): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_DATE_FILTER', startDate, endDate })

        api.Reports.Dashboard(startDate, endDate)
            .then(response => {
                dispatch({ type: 'GET_DASHBOARD_MODEL', payload: response.data });
            });
    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_PV_SORT', column, direction });
    }
}

const today = new Date();
const unloadedState: DashboardState = {
    dashboardModel: {},
    rows: [],
    errors: '',
    saleTypeFilter: [],
    hostessFilter: [],
    startDate: moment().add(-1, 'year'),
    endDate: moment(),
    sortColumn: 'date',
    sortDirection: 'DESC',
    loading: true
}

export const reducer: Reducer<DashboardState> = (state: DashboardState, incomingAction: Action) => {
    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'GET_PV_ROWS':
            return { ...state, errors: '', rows: action.payload, loading: false };
        case 'UPDATE_PV_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        case 'UPDATE_SALE_FILTER':
            return { ...state, saleTypeFilter: action.saleTypeFilter };
        case 'UPDATE_HOSTESS_FILTER':
            return { ...state, hostessFilter: action.hostessFilter };
        case 'UPDATE_DATE_FILTER':
            return { ...state, startDate: action.startDate, endDate: action.endDate };
        case 'GET_DASHBOARD_MODEL':
            return { ...state, dashboardModel: action.payload };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

