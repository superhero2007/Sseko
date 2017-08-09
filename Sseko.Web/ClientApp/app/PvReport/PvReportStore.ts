import axios from 'axios';
import { Action, Reducer, ActionCreator } from 'redux';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';
import { AppThunkAction } from '../../store';

export interface PvReportState {
    rows: PvRow[],
    saleTypeFilter: string[],
    hostessFilter: string[],
    sortColumn: string,
    sortDirection: string,
    startDate: Date,
    endDate: Date,
    errors: string
}

interface GetPvRows { type: 'GET_PV_ROWS', payload: PvRow[] }
interface UpdateSort { type: 'UPDATE_PV_SORT', column: string, direction: string }
interface UpdateSaleTypeFilter { type: 'UPDATE_SALE_FILTER', saleTypeFilter: string[] }
interface UpdateHostessFilter { type: 'UPDATE_HOSTESS_FILTER', hostessFilter: string[] }
interface UpdateDateFilter { type: 'UPDATE_DATE_FILTER', startDate: Date, endDate: Date }

type KnownAction = GetPvRows | UpdateSort | UpdateSaleTypeFilter | UpdateHostessFilter | UpdateDateFilter;

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

    updateSaleFilter: (saleTypes: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_SALE_FILTER', saleTypeFilter: saleTypes });
    },

    updateHostessFilter: (hostessFilter: string[]): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_HOSTESS_FILTER', hostessFilter });
    },

    updateDateFilter: (startDate: Date, endDate: Date): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_DATE_FILTER', startDate, endDate })
    },

    updateSort: (column: string, direction: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        dispatch({ type: 'UPDATE_PV_SORT', column, direction });
    }
}

const today = new Date();
const unloadedState: PvReportState = {
    rows: [],
    errors: '',
    saleTypeFilter: ["Affiliate Sale", "Personal Purchase", "Hostess Program", "Other"],
    hostessFilter: [],
    startDate: new Date(today.getFullYear(), today.getMonth(), 1),
    endDate: new Date(today.getFullYear(), today.getMonth() + 1, 0),
    sortColumn: 'date',
    sortDirection: 'ASC'
}

export const reducer: Reducer<PvReportState> = (state: PvReportState, action: KnownAction) => {
    switch (action.type) {
        case 'GET_PV_ROWS':
            return { ...state, errors: '', rows: action.payload };
        case 'UPDATE_PV_SORT':
            return { ...state, sortColumn: action.column, sortDirection: action.direction };
        case 'UPDATE_SALE_FILTER':
            return { ...state, saleTypeFilter: action.saleTypeFilter };
        case 'UPDATE_HOSTESS_FILTER':
            return { ...state, hostessFilter: action.hostessFilter };
        case 'UPDATE_DATE_FILTER':
            return { ...state, startDate: action.startDate, endDate: action.endDate };
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