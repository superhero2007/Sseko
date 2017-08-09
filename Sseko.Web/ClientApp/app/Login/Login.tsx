import * as React from 'react';
import { NavLink } from 'react-router-dom';
import { Textbox } from '../../components/Textbox'

export const Login = (props: LoginProps) => {
    return (
        <div className="login-form scale">
            <div className="form">
                <div className="auth-form-header">
                    <h1>Sign in to Sseko</h1>
                    {props.error && <div className="alert alert-danger">{this.props.error}</div>}
                </div>
                <div className="auth-form-body">
                    <div className="form-group">
                        <div className="input-group">
                            <span className="input-group-addon"><i className="fa fa-user"></i></span>
                            <div className="input-group-content">
                                <Textbox
                                    htmlId="username"
                                    name="username"
                                    label="Username"
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
                            <span className="input-group-addon"><i className="fa fa-key"></i></span>
                            <div className="input-group-content">
                                <Textbox
                                    htmlId="password"
                                    name="password"
                                    label="Password"
                                    type="password"
                                    onChange={props.onChange}
                                    value={props.user.password}
                                    error={props.errors.password}
                                />
                            </div>
                        </div>
                        <div className="form-group">
                            <div className="input-group">
                                <span className="input-group-addon">
                                    <NavLink to={'/ForgotPassword'}>Forgot Password?</NavLink>
                                    <i className="fa fa-question-circle" aria-hidden="true"></i>
                                </span>
                            </div>
                        </div>
                    </div>

                    <button type="submit" onClick={props.onSubmit} className="btn btn-default btn-block btn-submit signin-btn">Sign in</button>
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