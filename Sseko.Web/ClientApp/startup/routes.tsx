import * as React from 'react';
import { Route, Router, Switch } from 'react-router-dom';
import { Authorization } from './Authorization'

import { Layout } from '../components/Layout/Layout';
import { PageNotFound } from '../components/PageNotFound';
import DlReport from '../app/DlReport/DlReportContainer';
import ForgotPassword from '../app/account/ForgotPassword/ForgotPasswordContainer';
import Login from '../app/account/Login/LoginContainer';
import ManageUser from '../app/ManageUsers/ManageUsersContainer';
import Dashboard from '../app/Dashboard/DashboardContainer';
import PvReport from '../app/PvReport/PvReportContainer';
import ResetPassword from '../app/account/ResetPassword/ResetPasswordContainer';

const Fellow = Authorization(['fellow', 'admin']);
const Admin = Authorization(['admin'])

export const routes =
    <div>
        <Switch>
            <Route path='/Dashboard' component={Fellow(Dashboard)} />
            <Route path='/Login' component={Login} />

            <Route exact path='/Reports/' component={Fellow(PvReport)} />
            <Route path='/Reports/PersonalVolume/' component={Fellow(PvReport)} />
            <Route path='/Reports/DownLine/' component={Fellow(DlReport)} />

            <Route path='/Banners/' component={Fellow(DlReport)} />

            <Route path='/Manage/Users/' component={Admin(ManageUser)} />

            <Route path="/ForgotPassword" component={ForgotPassword} />
            <Route path="/ResetPassword/:code" component={ResetPassword}/>
            <Route path='*' component={Fellow(PageNotFound)} />
        </Switch>
    </div>
