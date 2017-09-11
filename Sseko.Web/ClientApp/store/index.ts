import AuthState from './AuthState';
import PvReportState from './PvReportState';
import DlReportState from './DlReportState';
import ManageUserState from './ManageUsersState';

import * as Auth from '../app/account/AuthStore';
import * as PvReport from '../app/PvReport/PvReportStore';
import * as DlReport from '../app/DlReport/DlReportStore';
import * as ManageUsers from '../app/ManageUsers/ManageUserStore';

// The top-level state object
export interface ApplicationState {
    auth: AuthState,
    pvReport: PvReportState,
    dlReport: DlReportState,
    users: ManageUserState,
}

// Whenever an action is dispatched, Redux will update each top-level application state property using
// the reducer with the matching name. It's important that the names match exactly, and that the reducer
// acts on the corresponding ApplicationState property type.
export const reducers = {
    auth: Auth.reducer,
    pvReport: PvReport.reducer,
    dlReport: DlReport.reducer,
    users: ManageUsers.reducer,
};

// This type can be used as a hint on action creators so that its 'dispatch' and 'getState' params are
// correctly typed to match your store.
export interface AppThunkAction<TAction> {
    (dispatch: (action: TAction) => void, getState: () => ApplicationState): void;
}
