import * as React from 'react';
import { Route, Router } from 'react-router-dom';
import { Authorization } from './Authorization'

import { Layout } from '../app/shared/Layout'
import { Home } from '../app/Home';
import { PvReport } from '../app/PvReport';
import { DlReport } from '../app/DlReport';
import Login from '../app/Login';

const Fellow = Authorization(['fellow', 'admin']);
const Admin = Authorization(['admin'])

export const routes =
    <div>
        <Route path='/Login' component={Login} />
        <Route exact path='/' component={Fellow(Home)} />
        <Route path='/Reports/PersonalVolume/' component={Fellow(PvReport)} />
        <Route path='/Reports/DownLine/' component={Fellow(DlReport)} />
    </div>
