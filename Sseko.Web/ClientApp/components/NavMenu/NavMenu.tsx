import * as React from 'react';
import { NavLink, Link } from 'react-router-dom';
import { FellowLinkGroup } from './FellowLinkGroup';
import { AdminLinkGroup } from './AdminLinkGroup';

interface NavMenuProps {
    role: string
}

export const NavMenu = (props: NavMenuProps) => {
    return (
        <div className='main-nav'>
            <div className='navbar navbar-inverse'>
                <div className='navbar-header'>
                    <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                        <span className='sr-only'>Toggle navigation</span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                    </button>
                    <Link className='navbar-brand' to={'/'}>Sseko</Link>
                </div>
                <div className='clearfix'></div>
                <div className='navbar-collapse collapse'>
                    {props.role == 'fellow' && <FellowLinkGroup />}
                    {props.role == 'admin' && <AdminLinkGroup />}
                </div>
            </div>
        </div>
    );
}