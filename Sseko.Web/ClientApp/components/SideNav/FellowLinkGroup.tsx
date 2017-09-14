import * as React from 'react';
import { NavBarLink } from './NavBarLink';
import { NavBarLinkSingle } from './NavBarLinkSingle';
import { NavBarLinkGroup } from './NavBarLinkGroup';
const dashboardIcon = require<string>('../../img/dashboard-ico.png');
const reportsIcon = require<string>('../../img/reports-ico.png');
const storeCreditIcon = require<string>('../../img/storecredit-ico.png');
const logoutIcon = require<string>('../../img/logout-ico.png');
// Active icons
const dashboardIconActive = require<string>('../../img/dashboard-active-ico.png');
const reportsIconActive = require<string>('../../img/reports-active-ico.png');
const storeCreditIconActive = require<string>('../../img/storecredit-active-ico.png');
const logoutIconActive = require<string>('../../img/logout-active-ico.png');

export const FellowLinkGroup = () => {
    return (
        <ul className="nav" id="side-menu">
            <li className="nav-header-custom"></li>
            <NavBarLinkSingle
                href='/Reports/PersonalVolume'
                imgSrc={reportsIcon}
                label='Personal Volume'
                exact={false}
            />
            <NavBarLinkSingle
                href='/Reports/Downline'
                imgSrc={reportsIcon}
                label='Downline Summary'
                exact={false}
            />
            <NavBarLinkSingle
                href='/Login'
                imgSrc={logoutIcon}
                label='Log out'
                exact={false}
            />
        </ul>
    );
}