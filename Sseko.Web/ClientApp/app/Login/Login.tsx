import * as React from 'react';
import { NavLink } from 'react-router-dom';
import { Textbox } from '../../components/Textbox'
import loginLogo = require('../../img/logo-login.png');
import userIcon = require('../../img/user-ico.png');
import passwordIcon = require('../../img/password-ico.png');

export const Login = (props: LoginProps) => {
    return (
        <div className="login-form scale">
            <div className="form">
                <div className="auth-form-body">
                    {/* TODO optimize images https://survivejs.com/webpack/loading/images/ */}
                    <img src={loginLogo} />
                    <h1>FELLOW INFORMATION</h1>
                    <h2>Please login to your account</h2>
                    <div className="form-group">
                        <div className="input-group">
                            <span className="input-group-addon"><img src={userIcon} /></span>
                            <div className="input-group-content">
                                <Textbox
                                    htmlId="username"
                                    name="username"
                                    label={null}
                                    placeholder="Username"
                                    type="text"
                                    onChange={props.onChange}
                                    value={props.user.username}
                                    error={props.errors.username}
                                />
                            </div>
                        </div>
                    </div>
                    <div className="form-group">
                        <div className="input-group">
                            <span className="input-group-addon"><img src={passwordIcon} /></span>
                            <div className="input-group-content">
                                <Textbox
                                    htmlId="password"
                                    name="password"
                                    label={null}
                                    placeholder="Password"
                                    type="password"
                                    onChange={props.onChange}
                                    value={props.user.password}
                                    error={props.errors.password}
                                />
                            </div>
                        </div>
                    </div>
                    {props.error && <div className="alert alert-danger">{props.error}</div>}
                    <button type="submit" onClick={props.onSubmit} className="btn btn-default btn-block btn-submit signin-btn">Login</button>
                    <NavLink to={'/ForgotPassword'}>Forgot Your Password?</NavLink>
                </div>
            </div >
        </div>
    );
}

interface LoginProps {
    error: string;
    errors: any;
    user: any;
    onSubmit: () => any;
    onChange: (event: any) => any;
}