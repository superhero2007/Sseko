import * as Auth from '../app/Login/LoginStore';
import * as PvReport from '../app/PvReport/PvReportStore';
import * as DlReport from '../app/DlReport/DlReportStore';
import * as ManageUser from '../app/ManageUsers/ManageUserStore';
import * as ForgotPassword from '../app/ForgotPassword/ForgotPasswordStore';
import * as ResetPassword from '../app/ResetPassword/ResetPasswordStore';

// The top-level state object
export interface ApplicationState {
    auth: Auth.AuthState,
    pvReport: PvReport.PvReportState,
    dlReport: DlReport.DlReportState,
    users: ManageUser.ManageUserState,
    forgotPassword: ForgotPassword.ForgotPasswordState,
    resetPassword: ResetPassword.ResetPasswordState
}

// Whenever an action is dispatched, Redux will update each top-level application state property using
// the reducer with the matching name. It's important that the names match exactly, and that the reducer
// acts on the corresponding ApplicationState property type.
export const reducers = {
    auth: Auth.reducer,
    pvReport: PvReport.reducer,
    dlReport: DlReport.reducer,
    users: ManageUser.reducer,
    forgotPassword: ForgotPassword.reducer,
    resetPassword: ResetPassword.reducer
};

// This type can be used as a hint on action creators so that its 'dispatch' and 'getState' params are
// correctly typed to match your store.
export interface AppThunkAction<TAction> {
    (dispatch: (action: TAction) => void, getState: () => ApplicationState): void;
}
