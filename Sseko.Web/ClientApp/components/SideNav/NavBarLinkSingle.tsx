import * as React from 'react'
import { NavLink } from 'react-router-dom';

interface NavBarLinkProps {
    href: string,
    label: string,
    icon: string,
    exact: boolean
}

export class NavBarLinkSingle extends React.Component<NavBarLinkProps, {}> {
    render() {
        const exact = this.props.exact || true;
        return (
            <li>
                <NavLink exact={exact} to={this.props.href} activeClassName='active'>
                    <img src={this.props.icon} /> {this.props.label}
                </NavLink>
            </li>
        );
    }
}