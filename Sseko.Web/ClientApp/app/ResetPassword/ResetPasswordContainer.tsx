import * as React from 'react';
import * as ResetStore from './ResetPasswordStore'
import { ApplicationState } from '../../store';
import { connect } from 'react-redux';
import { ResetPassword } from './ResetPassword';
import { match } from 'react-router-dom';

type ResetPasswordProps = ResetStore.ResetPasswordState & typeof ResetStore.actionCreators & RouteProps;

interface ResetPasswordState {
    auth: {
        password: string,
        passwordConfirmation: string
    },
    errors: any,
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

        this.state = { auth: { password: '', passwordConfirmation: '' }, errors: [] }

        this.onSubmit = this.onSubmit.bind(this);
        this.onChange = this.onChange.bind(this);
    }

    onSubmit() {
        if (!this.validate()) return;
        this.props.submitRequest(this.props.email, this.state.auth.password);
    }

    componentWillMount() {
        this.props.getEmail(this.props.match.params.code);
    }

    validate() {
        const { auth } = this.state;

        if (auth.password != auth.passwordConfirmation)
            this.setState({ errors: { passwordConfirmation: 'Passwords must match' } })
        else if (auth.password.length > 8)
            this.setState({ errors: { password: 'Password must be at least 8 characters' } })
        else
            return true;
        return false;
    }

    onChange(event) {
        var auth = this.state.auth;
        auth[event.target.name] = event.target.value;
        this.setState({ auth });
    }

    render() {
        return <ResetPassword
            auth={this.state.auth}
            errors={this.state.errors}
            onChange={this.onChange}
            onSubmit={this.onSubmit}
            submitError={this.props.error}
            submitted={this.props.submitted}
            email={this.props.email}
        />
    }
}

export default connect(
    (state: ApplicationState) => state.resetPassword,
    ResetStore.actionCreators
)(ResetPasswordContainer) as typeof ResetPasswordContainer;