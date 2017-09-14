import * as React from 'react';
import { NavLink } from 'react-router-dom';
import { Dropdown } from 'react-bootstrap';
import { FellowLinkGroup } from './SideNav/FellowLinkGroup';
import { AdminLinkGroup } from './SideNav/AdminLinkGroup';
import { smoothlyMenu } from './Helpers';
const loginLogo = require<string>('../img/logo-login.png');
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
    toggleNavigation = (e) => {
        e.preventDefault();
        $("body").toggleClass("mini-navbar");
        smoothlyMenu();
        this.setState((prevState) => ({ sideNavCollapsed: !prevState.sideNavCollapsed }));
    }

    render() {
        return (
            <div className="row border-bottom">
                <nav className="navbar navbar-static-top white-bg" role="navigation" style={{ marginLeft: !this.state.sideNavCollapsed && "-220px" || "-70px" }}>
                    <div className="navbar-header">
                        <button className="navbar-minimalize minimalize-styl-2 btn btn-primary" onClick={this.toggleNavigation}><i className="fa fa-bars"></i></button>
                        <img src={loginLogo} />
                    </div>
                    <ul className="nav navbar-top-links navbar-right">
                        <li>
                            <NavLink to="/Login">
                                Log Out
                            </NavLink>
                        </li>
                    </ul>
                </nav>
            </div>
        )
    }
}

export default TopHeader