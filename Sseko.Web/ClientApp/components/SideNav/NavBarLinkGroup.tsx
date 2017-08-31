import * as React from 'react'
import { NavLink } from 'react-router-dom';

interface NavBarLinkProps {
    href: string,
    label: string,
    icon: string,
    exact: boolean
}

export class NavBarLinkGroup extends React.Component<NavBarLinkProps, {}> {
    state = { collapsed: false }

    handleClick = () => {
        var { collapsed } = this.state;
        collapsed = !collapsed;
        this.setState({ collapsed });
    }

    render() {
        return (
            <li className={"nav-group" + (this.state.collapsed ? " collapsed" : "")}>
                <div onClick={this.handleClick}><img src={this.props.icon} /> {this.props.label} <i className={"glyphicon glyphicon-chevron-" + (this.state.collapsed ? "down" : "up")}></i></div>
                {this.props.children}
            </li>
        );
    }
}