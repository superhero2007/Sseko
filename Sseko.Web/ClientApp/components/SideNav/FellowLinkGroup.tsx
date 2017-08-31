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
        return (
            <ul className='nav navbar-nav'>
                <NavBarLinkSingle
                    icon={dashboardIcon}
                    href='/'
                    label='Dashboard'
                    exact={true} // TODO fix
                />
                <NavBarLinkGroup icon={reportsIcon} label="Reports">
                    <NavBarLink
                        href='/Reports/PersonalVolume'
                        label='Personal Volume'
                    />
                    <NavBarLink
                        href='/Reports/Downline'
                        label='Downline Summary'
                    />
                </NavBarLinkGroup>
                <NavBarLinkSingle
                    icon={storeCreditIcon}
                    href='/' // TODO add store credit
                    label='Store Credit'
                />
                <NavBarLinkSingle
                    icon={bannersIcon}
                    href='/' // TODO add banners and links
                    label='Banners & Links'
                />
                <NavBarLinkSingle
                    icon={logoutIcon}
                    href='/Login'
                    label='Logout'
                />
            </ul>
        );
}