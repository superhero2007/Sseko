import * as React from 'react';
import './TopHeader.css';
import { NavLink } from 'react-router-dom';
import { Dropdown } from 'react-bootstrap';
import { FellowLinkGroup } from '../SideNav/FellowLinkGroup';
import { AdminLinkGroup } from '../SideNav/AdminLinkGroup';
import { smoothlyMenu } from '../Helpers';
const loginLogo = require<string>('../../img/logo-login.png');
declare let $: any;

interface TopHeaderProps {
    role: string
}

interface TopHeaderState {
    sideNavCollapsed: boolean
}

class TopHeader extends React.Component<TopHeaderProps, TopHeaderState> {
    constructor(props) {
        super(props);
        this.state = { sideNavCollapsed: false };
    }

    // From Inspinia Template
    toggleNavigation = (e) => {
        e.preventDefault();
        $("body").toggleClass("mini-navbar");
        smoothlyMenu();
        // TODO scale() the datatable
        this.setState((prevState) => ({ sideNavCollapsed: !prevState.sideNavCollapsed }));
    }

    render() {
        return (
            <nav className="navbar navbar-static-top" role="navigation">
                <div className="navbar-header">
                    <span className={"hamburger" + (this.state.sideNavCollapsed ? "" : " open")} onClick={this.toggleNavigation}>
                        <span className="hamburger-top"></span>
                        <span className="hamburger-middle"></span>
                        <span className="hamburger-bottom"></span>
                    </span>
                    <img src={loginLogo} />
                    <span>FELLOW INFORMATION</span>
                </div>
                <ul className="nav navbar-top-links navbar-right">
                    <li>
                        <NavLink to="/Login">
                            Log Out
                        </NavLink>
                    </li>
                </ul>
            </nav>
        )
    }
}

export default TopHeader