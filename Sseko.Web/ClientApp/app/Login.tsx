import * as React from 'react';
import { NavLink } from 'react-router-dom';
import { connect } from 'react-redux';
import * as Auth from '../store/Auth';
import { ApplicationState } from '../store'
import { Textbox } from '../components/Textbox'

type LoginProps = Auth.AuthState & typeof Auth.actionCreators

interface LoginState {
    user: User,
    errors: User
}

interface User {
    username: string,
    password: string,
}

class Login extends React.Component<LoginProps, LoginState> {
    constructor(props) {
        super(props);

        this.state = {
            user: { username: '', password: '' },
            errors: { username: '', password: '' }
        }
        this.onChange = this.onChange.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
    }

    onSubmit = () => {
        this.props.loginUser(this.state.user.username, this.state.user.password);
    }

    onChange = (event) => {
        const user = this.state.user;
        user[event.target.name] = event.target.value
        this.setState({ user });
    }

    public render() {
        return <div className="login-form scale">
            <div className="form">
                <div className="auth-form-header">
                    <h1>Sign in to Sseko</h1>
                    {this.props.error && <div className="alert alert-danger">{this.props.error}</div>}
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
                                    onChange={this.onChange}
                                    value={this.state.user.username}
                                    error={this.state.errors.username}
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
                                    onChange={this.onChange}
                                    value={this.state.user.password}
                                    error={this.state.errors.password}
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

                    <button type="submit" onClick={this.onSubmit} className="btn btn-default btn-block btn-submit signin-btn">Sign in</button>
                </div>
            </div >
        </div>
    }
}
export default connect(
    (state: ApplicationState) => state.auth,
    Auth.actionCreators
)(Login) as typeof Login;