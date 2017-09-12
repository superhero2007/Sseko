import * as React from 'react';
import { NavBarLink } from './NavBarLink';


export const AdminLinkGroup = () => {
    return (
        <ul className='nav'>
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