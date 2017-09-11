import * as React from 'react';
import { Dropdown } from 'react-bootstrap';
import { FellowLinkGroup } from './FellowLinkGroup';
import { AdminLinkGroup } from './AdminLinkGroup';
declare let $: any;

interface NavigationProps {
    role: string
}

class Navigation extends React.Component<NavigationProps, {}> {
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
                                <span className="clear">
                                    <span className="block m-t-xs"> <strong className="font-bold">Example user</strong>
                                </span>
                                <span className="text-muted text-xs block">
                                    Example position<b className="caret"></b></span>
                                </span>
                            </a>
                            <ul className="dropdown-menu animated fadeInRight m-t-xs">
                                <li><a href="Login"> Logout</a></li>
                            </ul>
                        </div>
                        <div className="logo-element">
                            IN+
                        </div>
                    </li>
                    {this.props.role === 'fellow' && <FellowLinkGroup />}
                    {this.props.role === 'admin' && <AdminLinkGroup />}
                </ul>
            </nav>
        )
    }
}

export default Navigation