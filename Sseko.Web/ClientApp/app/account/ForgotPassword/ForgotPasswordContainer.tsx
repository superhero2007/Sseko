import * as AuthStore from '../AuthStore';
import * as React from 'react';
import { ApplicationState } from '../../../store';
import { connect } from 'react-redux';
import { ForgotPassword } from './ForgotPassword';
import AuthState from '../../../store/AuthState';

type ForgotPasswordProps = AuthState & typeof AuthStore.actionCreators;

interface ForgotPasswordState {
    email: string
}

class ForgotPasswordContainer extends React.Component<ForgotPasswordProps, ForgotPasswordState> {
    constructor(props) {
        super(props);

        this.state = { email: '' };

        this.onSubmit = this.onSubmit.bind(this);
        this.onChange = this.onChange.bind(this);
    }

    onSubmit() {
        this.props.sendResetLink(this.state.email);
    }

    onChange = (event) => {
        this.setState({ email: event.target.value });
    }

    render() {
        return <ForgotPassword
            onSubmit={this.onSubmit}
            submitted={this.props.passwordResetFormSent}
            email={this.state.email}
            onEmailChange={this.onChange}
        />
    }
}

export default connect(
    (state: ApplicationState) => state.auth,
    AuthStore.actionCreators
)(ForgotPasswordContainer) as typeof ForgotPasswordContainer;