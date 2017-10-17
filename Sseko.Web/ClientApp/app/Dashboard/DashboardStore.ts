import * as dtos from '../../dtos';
import * as api from '../../api';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import DashboardState from '../../store/DashboardState';
import * as moment from 'moment';
import { extendMoment } from 'moment-range';
const Moment = extendMoment(moment);

interface GetDashboardModel { type: 'GET_DASHBOARD_MODEL', payload: any }
interface UpdateDateFilter { type: 'UPDATE_DATE_FILTER', startDate: moment.Moment, endDate: moment.Moment }

type KnownAction = GetDashboardModel | UpdateDateFilter;

export const actionCreators = {
    getDashboardModel: (startDate: moment.Moment, endDate: moment.Moment): AppThunkAction<KnownAction> => (dispatch, getState) => {
        api.Reports.Dashboard(startDate, endDate)
            .then(response => {
                dispatch({ type: 'GET_DASHBOARD_MODEL', payload: response.data });
            });
    },

    updateDateFilter: (startDate: moment.Moment, endDate: moment.Moment): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_DATE_FILTER', startDate, endDate })

        api.Reports.Dashboard(startDate, endDate)
            .then(response => {
                dispatch({ type: 'GET_DASHBOARD_MODEL', payload: response.data });
            });
    }
}

const today = new Date();
const unloadedState: DashboardState = {
    dashboardModel: {},
    errors: '',
    startDate: Moment().add(-1, 'year'),
    endDate: Moment(),
    loading: true
}

export const reducer: Reducer<DashboardState> = (state: DashboardState, incomingAction: Action) => {
    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'UPDATE_DATE_FILTER':
            return { ...state, startDate: action.startDate, endDate: action.endDate };
        case 'GET_DASHBOARD_MODEL':
            return { ...state, dashboardModel: action.payload };
        default:
            const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
}

