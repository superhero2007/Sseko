import * as React from 'react';
import { Dropdown } from 'react-bootstrap';
import { FellowLinkGroup } from './SideNav/FellowLinkGroup';
import { AdminLinkGroup } from './SideNav/AdminLinkGroup';
import { smoothlyMenu } from './Helpers';
declare let $: any;

interface TopHeaderProps {
    role: string;
}

class TopHeader extends React.Component<TopHeaderProps, {}> {

    toggleNavigation(e) {
        e.preventDefault();
        $("body").toggleClass("mini-navbar");
        smoothlyMenu();
    }

    render() {
        return (
            <div className="row border-bottom">
                <nav className="navbar navbar-static-top white-bg" role="navigation" style={{ marginBottom: 0 }}>
                    <div className="navbar-header">
                        <a className="navbar-minimalize minimalize-styl-2 btn btn-primary " onClick={this.toggleNavigation} href="#"><i className="fa fa-bars"></i> </a>
                    </div>
                    {this.props.role === 'fellow' && <FellowLinkGroup />}
                    {this.props.role === 'admin' && <AdminLinkGroup />}
                </nav>
            </div>
        )
    }
}

export default TopHeader