import * as React from 'react';
import { NavBarLinkSingle } from './NavBarLinkSingle';
const dashboardIcon = require<string>('../../img/dashboard-ico.png');
const reportsIcon = require<string>('../../img/reports-ico.png');
const linkIcon = require<string>('../../img/link-ico.png');
const logoutIcon = require<string>('../../img/logout-ico.png');
// Active icons
const dashboardIconActive = require<string>('../../img/dashboard-active-ico.png');
const reportsIconActive = require<string>('../../img/reports-active-ico.png');
const linkIconActive = require<string>('../../img/link-active-ico.png');
const logoutIconActive = require<string>('../../img/logout-active-ico.png');

export const FellowLinkGroup = () => {
    return (
        <ul className="nav metismenu" id="side-menu">
            <NavBarLinkSingle
                href='/Dashboard'
                imgSrc={dashboardIcon}
                imgActiveSrc={dashboardIconActive}
                label='Dashboard'
            />
            <NavBarLinkSingle
                href='/Reports'
                imgSrc={reportsIcon}
                imgActiveSrc={reportsIconActive}
                label='Reports'
            >
                <ul className="nav nav-second-level collapse">
                    <NavBarLinkSingle
                        href='/Reports/PersonalVolume'
                        label='Personal Volume'
                    />
                    <NavBarLinkSingle
                        href='/Reports/Downline'
                        label='Downline Summary'
                    />
                </ul>
            </NavBarLinkSingle>
            <NavBarLinkSingle
                href='/Banners'
                imgSrc={linkIcon}
                imgActiveSrc={linkIconActive}
                label='Banners & Links'
            />
            <NavBarLinkSingle
                href='/Login'
                imgSrc={logoutIcon}
                imgActiveSrc={logoutIconActive}
                label='Log out'
            />
        </ul>
    );
}