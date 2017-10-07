import * as React from 'react';
import { NavBarLinkSingle } from './NavBarLinkSingle';
const dashboardIcon = require<string>('../../img/dashboard-ico.png');
const linkIcon = require<string>('../../img/link-ico.png');

const dashboardIconActive = require<string>('../../img/dashboard-active-ico.png');
const linkIconActive = require<string>('../../img/link-active-ico.png');


export const AdminLinkGroup = () => {
    return (
        <ul className="nav metismenu" id="side-menu">
            <NavBarLinkSingle
                href='/Dashboard'
                label='Dashboard'
                imgSrc={dashboardIcon}
                imgActiveSrc={dashboardIconActive}
            />
            <NavBarLinkSingle
                href='/Manage/Users'
                label='Manage Users'
                imgSrc={linkIcon}
                imgActiveSrc={linkIconActive}
            />
        </ul>
    );
}