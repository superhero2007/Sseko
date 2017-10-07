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
        $("#side-menu").metisMenu();
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