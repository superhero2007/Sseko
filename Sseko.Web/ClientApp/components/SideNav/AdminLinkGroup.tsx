import * as React from 'react';
import { NavBarLink } from './NavBarLink';


export const AdminLinkGroup = () => {
    return (
        <ul className='nav navbar-nav'>
            <NavBarLink
                icon='glyphicon glyphicon-home'
                href='/'
                label='Home'
                exact
            />
            <NavBarLink
                icon='glyphicon glyphicon-education'
                href='/Manage/Users'
                label='Manage Users'
                exact={false}
            />
        </ul>
    );
}