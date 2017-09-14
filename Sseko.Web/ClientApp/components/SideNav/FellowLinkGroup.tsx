import * as React from 'react';
import { NavBarLink } from './NavBarLink';
import { NavBarLinkSingle } from './NavBarLinkSingle';
import { NavBarLinkGroup } from './NavBarLinkGroup';
const dashboardIcon = require('../../img/dashboard-ico.png');
const reportsIcon = require('../../img/reports-ico.png');
const storeCreditIcon = require('../../img/storecredit-ico.png');
const logoutIcon = require('../../img/logout-ico.png');
// Active icons
const dashboardIconActive = require('../../img/dashboard-active-ico.png');
const reportsIconActive = require('../../img/reports-active-ico.png');
const storeCreditIconActive = require('../../img/storecredit-active-ico.png');
const logoutIconActive = require('../../img/logout-active-ico.png');

export const FellowLinkGroup = () => {
    return (
        <ul className="nav" id="side-menu">
            <li className="nav-header-custom"></li>
            <NavBarLinkSingle
                href='/Reports/PersonalVolume'
                //icon={dashboardIcon}
                label='Personal Volume'
                exact={false}
            />
            <NavBarLinkSingle
                href='/Reports/Downline'
                //icon={reportsIcon}
                label='Downline Summary'
                exact={false}
            />
            <NavBarLinkSingle
                href='/Login'
                label='Log out'
                exact={false}
            />
        </ul>
    );
}