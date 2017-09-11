import * as React from 'react';
import { NavLink, Link } from 'react-router-dom';
import { FellowLinkGroup } from './FellowLinkGroup';
import { AdminLinkGroup } from './AdminLinkGroup';

interface SideNavProps {
    role: string
}

export const SideNav = (props: SideNavProps) =>
    <div className='main-nav'>
        <div className='navbar'>
            <div className='navbar-header'>
                <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                    <i className='glyphicon glyphicon-chevron-down'></i>
                    <span className='sr-only'>Toggle navigation</span>
                </button>
            </div>
            <div className='clearfix'></div>
            <div className='navbar-collapse collapse'>
                {this.props.role === 'fellow' && <FellowLinkGroup />}
                {this.props.role === 'admin' || true && <AdminLinkGroup />}
            </div>
        </div>
    </div>;