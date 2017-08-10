    import * as React from 'react'
import { NavLink } from 'react-router-dom';

interface NavBarLinkProps {
    href: string,
    label: string,
    icon: string,
    exact: boolean
}

export class NavBarLink extends React.Component<NavBarLinkProps, {}> {
    render() {
        const exact = this.props.exact;
        return (    
            <li>
                <NavLink exact={exact} to={this.props.href} activeClassName='active'>
                    <span className={this.props.icon}></span> {this.props.label}
                </NavLink>
            </li>
        );
    }
}