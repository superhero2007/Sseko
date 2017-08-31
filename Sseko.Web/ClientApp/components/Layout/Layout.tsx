import * as React from 'react';
import { SideNav } from '../SideNav/SideNav';
import { TopNav } from '../TopNav/TopNav';
import { Footer } from './Footer';
import { GetRole, GetUsername } from '../../utils/AuthService';


export class Layout extends React.Component<{}, {}> {
    public render() {
        return (
            <div className={'container-fluid ' + this.props.containerClassName}>
                <div className='row'>
                    <SideNav role={GetRole()} username={GetUsername()}/>
                    <div className='body-content'>
                        {this.props.children}
                        <Footer />
                    </div>
                </div>
            </div>
        );
    }
}