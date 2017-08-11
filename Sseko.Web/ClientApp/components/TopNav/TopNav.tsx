import './TopNav.css';
import * as React from 'react';
import { NavLink } from 'react-router-dom';

export class TopNav extends React.Component<TopNavProps, {}>{
    onClick() {
        document.getElementById("profile-dropdown").classList.toggle("show");
    }

    render() {
        return (
            <div className="topnav" id="top-nav">
                <div id="login-dropdown" className="dropdown">
                    <button onClick={this.onClick} className="dropbtn">{this.props.username}</button>
                    <div id="profile-dropdown" className="dropdown-content">
                        <NavLink to="/Login">Logout</NavLink>
                    </div>
                </div>
            </div>
        );
    }
}

interface TopNavProps {
    username: string
}