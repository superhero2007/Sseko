import * as React from 'react'
import { NavLink } from 'react-router-dom';

interface NavBarLinkProps {
    href: string;
    label: string;
    imgSrc?: string;
    //icon?: string;
    exact: boolean;
}

export const NavBarLinkSingle = (props: NavBarLinkProps) =>
    <li>
        <NavLink exact={props.exact || true} to={props.href} activeClassName='active'>
            <img src={props.imgSrc} /> <span>{props.label}</span>
        </NavLink>
    </li>;