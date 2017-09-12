import * as React from 'react';
import { NavBarLink } from './NavBarLink';
import { NavBarLinkSingle } from './NavBarLinkSingle';
import { NavBarLinkGroup } from './NavBarLinkGroup';
import dashboardIcon = require('../../img/dashboard-ico.png');
import reportsIcon = require('../../img/reports-ico.png');
import storeCreditIcon = require('../../img/storecredit-ico.png');
import bannersIcon = require('../../img/banners-ico.png');
import logoutIcon = require('../../img/logout-ico.png');
// Active icons
import dashboardIconActive = require('../../img/dashboard-active-ico.png');
import reportsIconActive = require('../../img/reports-active-ico.png');
import storeCreditIconActive = require('../../img/storecredit-active-ico.png');
import bannersIconActive = require('../../img/banners-active-ico.png');
import logoutIconActive = require('../../img/logout-active-ico.png');

export const FellowLinkGroup = () => {
        return ( // Refer to version control history when adding to navigation
            <ul className='nav navbar-top-links navbar-right'>
                <NavBarLinkSingle
                    href='/Reports/PersonalVolume'
                    label='Personal Volume'
                    exact={false}
                />
                <NavBarLinkSingle
                    href='/Reports/Downline'
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