import * as React from 'react'
import { Link } from 'react-router-dom';

interface NavBarLinkProps {
    href: string;
    label: string;
    imgSrc?: string;
    imgActiveSrc?: string;
}

export class NavBarLinkSingle extends React.Component<NavBarLinkProps, {}> {
    render() {
        const active = window.location.pathname.indexOf(this.props.href) > -1;
        let element = null;
        if (this.props.imgSrc) {
            let href = this.props.href;
            element = (< Link to={href} >
                <img src={active ? this.props.imgActiveSrc : this.props.imgSrc} />
                <span className="nav-label">
                    {this.props.label}
                </span>
            </Link>);
        }
        else {
            element = (< Link to={this.props.href} >
                    {this.props.label}
            </Link>);
        }
        
        return (
            <li className={active ? "active" : ""} >
                {element}
                {this.props.children}
            </li>
        );
    }
}

