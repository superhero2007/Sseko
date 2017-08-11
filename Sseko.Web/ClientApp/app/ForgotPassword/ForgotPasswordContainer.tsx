import * as React from 'react';
import * as ResetStore from './ForgotPasswordStore'
import { ApplicationState } from '../../store';
import { connect } from 'react-redux';
import { ForgotPassword } from './ForgotPassword';

type ForgotPasswordProps = ResetStore.ForgotPasswordState & typeof ResetStore.actionCreators;

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
        this.props.submitRequest(this.state.email);
    }

    onChange = (event) => {
        this.setState({ email: event.target.value });
    }

    render() {
        return <ForgotPassword
            onSubmit={this.onSubmit}
            submitted={this.props.submitted}
            email={this.state.email}
            onEmailChange={this.onChange}
        />
    }
}

export default connect(
    (state: ApplicationState) => state.forgotPassword,
    ResetStore.actionCreators
)(ForgotPasswordContainer) as typeof ForgotPasswordContainer;