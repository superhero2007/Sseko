import * as React from 'react'
import { NavLink } from 'react-router-dom';

interface NavBarLinkProps {
    href: string;
    label: string;
    icon: string;
    iconActive: string;
    exact: boolean;
}

export const NavBarLinkSingle = (props: NavBarLinkProps) =>
    <li>
        <NavLink exact={props.exact || true} to={props.href} activeClassName='active'>
            <img src={props.icon} /><img className="active" src={props.iconActive} />{props.label}
        </NavLink>
    </li>;