import * as React from 'react';
import { NavMenu } from '../NavMenu/NavMenu';
import { Footer } from './Footer';
import { GetRole } from '../../utils/AuthService';


export class Layout extends React.Component<{}, {}> {
    public render() {
        return <div className='container-fluid'>
            <div className='row'>
                <div className='col-sm-3'>
                    <NavMenu role={GetRole()}/>
                </div>
                <div className='col-sm-9'>
                    {this.props.children}
                    <Footer />
                </div>
            </div>
        </div>
    }
}