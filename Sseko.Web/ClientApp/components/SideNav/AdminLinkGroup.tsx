import * as React from 'react';
import { NavBarLink } from './NavBarLink';


export const AdminLinkGroup = () => {
    return (
        <ul className="nav" id="side-menu">
            <li className="nav-header">
                <div className="logo-element">
                    IN+
                </div>
            </li>
            <NavBarLink
                href='/'
                label='Home'
                exact
            />
            <NavBarLink
                href='/Manage/Users'
                label='Manage Users'
                exact={false}
            />
        </ul>
    );
}