import * as React from 'react';
import { Dropdown } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';
declare let $: any;

class Navigation extends React.Component<{}, {}> {

    componentDidMount() {
        const { menu } = this.refs;
        $(menu).metisMenu();
    }

    activeRoute(routeName) {
        return -1 > -1 ? "active" : "";
    }

    secondLevelActive(routeName) {
        return -1 > -1 ? "nav nav-second-level collapse in" : "nav nav-second-level collapse";
    }

    render() {
        return (
            <nav className="navbar-default navbar-static-side" role="navigation">
                <ul className="nav metismenu" id="side-menu" ref="menu">
                    <li className="nav-header">
                        <div className="dropdown profile-element"> <span>
                        </span>
                            <a data-toggle="dropdown" className="dropdown-toggle" href="#">
                                <span className="clear"> <span className="block m-t-xs"> <strong className="font-bold">Example user</strong>
                                </span> <span className="text-muted text-xs block">Example position<b className="caret"></b></span> </span> </a>
                            <ul className="dropdown-menu animated fadeInRight m-t-xs">
                                <li><a href="#"> Logout</a></li>
                            </ul>
                        </div>
                        <div className="logo-element">
                            IN+
                            </div>
                    </li>
                    <li className={this.activeRoute("/main")}>
                        <NavLink to="/main"><i className="fa fa-th-large"></i> <span className="nav-label">Main view</span></NavLink>
                    </li>
                    <li className={this.activeRoute("/minor")}>
                        <NavLink to="/minor"><i className="fa fa-th-large"></i> <span className="nav-label">Minor view</span></NavLink>
                    </li>
                </ul>

            </nav>
        )
    }
}

export default Navigation