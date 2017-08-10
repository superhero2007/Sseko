import * as React from 'react';
import { NavBarLink } from './NavBarLink';


export const FellowLinkGroup = () => {
        return (
            <div className='navbar-collapse collapse'>
                <ul className='nav navbar-nav'>
                    <NavBarLink
                        icon='glyphicon glyphicon-home'
                        href='/'
                        label='Home'
                        exact
                    />
                    <NavBarLink
                        icon='glyphicon glyphicon-education'
                        href='/Reports/PersonalVolume'
                        label='PV Report'
                        exact={false}
                    />
                    <NavBarLink
                        icon='glyphicon glyphicon-th-list'
                        href='/Reports/Downline'
                        label='Downline Report'
                        exact={false}
                    />
                </ul>
            </div>
        );
}