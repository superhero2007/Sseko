import * as React from 'react';
import { NavBarLinkSingle } from './NavBarLinkSingle';


export const AdminLinkGroup = () => {
    return (
        <ul className="nav" id="side-menu">
            <NavBarLinkSingle
                href='/Dashboard'
                label='Dashboard'
            />
            <NavBarLinkSingle
                href='/Manage/Users'
                label='Manage Users'
            />
        </ul>
    );
}