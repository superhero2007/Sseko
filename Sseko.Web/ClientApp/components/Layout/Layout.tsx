import * as React from 'react';
import { SideNav } from '../SideNav/SideNav';
import { TopNav } from '../TopNav/TopNav';
import { Footer } from './Footer';
import { GetRole, GetUsername } from '../../utils/AuthService';


export class Layout extends React.Component<{}, {}> {
    public render() {
        return <div className='container-fluid'>
            <TopNav username={GetUsername()} />
            <div className='row'>
                <div className='col-sm-3'>
                    <SideNav role={GetRole()} />
                </div>
                <div className='col-sm-9'>
                    {this.props.children}
                    <Footer />
                </div>
            </div>
        </div>
    }
}