import * as React from 'react';
import { NavBarLink } from './NavBarLink';
import { NavBarLinkSingle } from './NavBarLinkSingle';
import { NavBarLinkGroup } from './NavBarLinkGroup';
import dashboardIcon = require('../../img/dashboard-ico.png');
import reportsIcon = require('../../img/reports-ico.png');
import storeCreditIcon = require('../../img/storecredit-ico.png');
import bannersIcon = require('../../img/banners-ico.png');
import logoutIcon = require('../../img/logout-ico.png');

export const FellowLinkGroup = () => {
        return ( // Refer to version control history when adding to navigation
            <ul className='nav navbar-nav'>
                <NavBarLinkSingle
                    icon={reportsIcon}
                    href='/Reports/PersonalVolume'
                    label='Personal Volume Report'
                />
                <NavBarLinkSingle
                    icon={reportsIcon}
                    href='/Reports/Downline'
                    label='Downline Summary Report'
                />
                <NavBarLinkSingle
                    icon={logoutIcon}
                    href='/Login'
                    label='Logout'
                />
            </ul>
        );
}