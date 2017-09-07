import * as React from 'react';
import { SideNav } from '../SideNav/SideNav';
import { TopNav } from '../TopNav/TopNav';
import { Footer } from './Footer';
import { GetRole, GetUsername } from '../../utils/AuthService';

interface LayoutProps {
    className: string;
    children?: any;
}

export const Layout = (props: LayoutProps) =>
    <div className={'container-fluid ' + (props.className || "")}>
        <div className='row'>
            <SideNav role={GetRole()} username={GetUsername()} />
            <div className='body-container'>
                <div className='body-content'>
                    {props.children}
                </div>
                <Footer />
            </div>
        </div>
    </div>