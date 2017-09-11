import * as AuthStore from '../AuthStore';
import * as dtos from '../../../dtos';
import * as React from 'react';
import { ApplicationState } from '../../../store'
import { connect } from 'react-redux';
import { Login } from './Login';
import { LogoutWithoutRedirect } from '../../../utils/AuthService';
import AuthState from '../../../store/AuthState';

type LoginProps = AuthState & typeof AuthStore.actionCreators

interface LoginState {
    user: dtos.UserForAuthDto,
    errors: dtos.UserForAuthDto
}

class LoginContainer extends React.Component<LoginProps, LoginState> {
    constructor(props) {
        super(props);

        this.state = {
            user: { username: '', password: '' },
            errors: { username: '', password: '' }
        }
        this.onChange = this.onChange.bind(this);
        this.onSubmit = this.onSubmit.bind(this);
    }

    componentWillMount() {
        LogoutWithoutRedirect();
    }

    onSubmit = () => {
        this.props.loginUser(this.state.user);
    }

    onChange = (event) => {
        const user = this.state.user;
        user[event.target.name] = event.target.value
        this.setState({ user });
    }

    public render() {
        return (
            <Login
                user={this.state.user}
                errors={this.state.errors}
                onChange={this.onChange}
                onSubmit={this.onSubmit}
                error={this.props.error}
            />
        );
    }
}
export default connect(
    (state: ApplicationState) => state.auth,
    AuthStore.actionCreators
)(LoginContainer) as typeof LoginContainer;