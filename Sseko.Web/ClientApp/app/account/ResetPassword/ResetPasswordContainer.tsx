import * as React from 'react';
import * as AuthStore from '../AuthStore'
import { ApplicationState } from '../../../store';
import { connect } from 'react-redux';
import { ResetPassword } from './ResetPassword';
import { match } from 'react-router-dom';
import AuthState from '../../../store/AuthState';
import * as dtos from '../../../dtos';

type ResetPasswordProps = AuthState & typeof AuthStore.actionCreators & RouteProps;

interface ResetPasswordState {
    user: dtos.UserForPasswordResetDto & { passwordConfirmation: string },
    errors: any
}

interface RouteProps {
    match?: match<ResetPasswordParams>
}

interface ResetPasswordParams {
    code: string
}

class ResetPasswordContainer extends React.Component<ResetPasswordProps, ResetPasswordState> {
    constructor(props) {
        super(props);

        this.state = { user: null, errors: [] }

        this.onSubmit = this.onSubmit.bind(this);
        this.onChange = this.onChange.bind(this);
    }

    onSubmit() {
        if (!this.validate()) return;
        this.props.resetPassword(this.state.user);
    }

    componentWillMount() {
        this.props.getEmail(this.props.match.params.code);
    }

    validate() {
        const { user } = this.state;

        if (user.password != user.passwordConfirmation)
            this.setState({ errors: { passwordConfirmation: 'Passwords must match' } })
        else if (user.password.length > 8)
            this.setState({ errors: { password: 'Password must be at least 8 characters' } })
        else
            return true;
        return false;
    }

    onChange(event) {
        var user = this.state.user;
        user[event.target.name] = event.target.value;
        this.setState({ user });
    }

    render() {
        return <ResetPassword
            auth={this.state.user}
            errors={this.state.errors}
            onChange={this.onChange}
            onSubmit={this.onSubmit}
            submitError={this.props.error}
            submitted={this.props.passwordResetFormSent}
            email={this.props.email}
        />
    }
}

export default connect(
    (state: ApplicationState) => state.auth,
    AuthStore.actionCreators
)(ResetPasswordContainer) as typeof ResetPasswordContainer;