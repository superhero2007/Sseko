import * as React from 'react';
import { Dropdown } from 'react-bootstrap';
import { FellowLinkGroup } from './FellowLinkGroup';
import { AdminLinkGroup } from './AdminLinkGroup';
declare let $: any;

interface NavigationProps {
    role: string,
    location: any
}

class Navigation extends React.Component<NavigationProps, {}> {
    componentDidMount() {
        const { menu } = this.refs;
        $(menu).metisMenu();
    }

    activeRoute(routeName) {
        return this.props.location.pathname.indexOf(routeName) > -1 ? "active" : "";
    }

    secondLevelActive(routeName) {
        return this.props.location.pathname.indexOf(routeName) > -1 ? "nav nav-second-level collapse in" : "nav nav-second-level collapse";
    }

    render() {
        return (
            <nav className="navbar-default navbar-static-side" role="navigation">
                {/* Duplicated code in the following components could be reduced with React 16 */}
                {this.props.role === 'fellow' && <FellowLinkGroup />}
                {this.props.role === 'admin' && <AdminLinkGroup />}
            </nav>
        )
    }
}

export default Navigation