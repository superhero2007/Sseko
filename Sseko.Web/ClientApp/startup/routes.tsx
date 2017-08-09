import * as React from 'react';
import { Route, Router } from 'react-router-dom';
import { Authorization } from './Authorization'

import { Layout } from '../app/Layout/Layout'
import { Home } from '../app/Home';
import PvReport from '../app/PvReport/PvReportContainer';
import DlReport from '../app/DlReport/DlReportContainer';
import Login from '../app/Login/LoginContainer';

const Fellow = Authorization(['fellow', 'admin']);
const Admin = Authorization(['admin'])

export const routes =
    <div>
        <Route path='/Login' component={Login} />
        <Route exact path='/' component={Fellow(Home)} />
        <Route path='/Reports/PersonalVolume/' component={Fellow(PvReport)} />
        <Route path='/Reports/DownLine/' component={Fellow(DlReport)} />
    </div>
