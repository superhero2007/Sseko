﻿import * as React from 'react'
import { NavLink } from 'react-router-dom';

interface NavBarLinkProps {
    href: string,
    label: string,
    exact: boolean,
}

export const NavBarLink = (props: NavBarLinkProps) =>
    <NavLink exact={props.exact || true} to={props.href} activeClassName='active'>
        {props.label}
    </NavLink>;