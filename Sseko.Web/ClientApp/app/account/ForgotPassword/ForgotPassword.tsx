import * as React from 'react';
import { Textbox } from '../../../components/Textbox';

export const ForgotPassword = (props: ForgotPasswordProps) => {
    return (
        <div className="login-form">
            <div className="form">
                {
                    !props.submitted
                        ? <div>
                            <Textbox
                                htmlId={"email-reset-input"}
                                label={"Email"}
                                name={"email"}
                                error={""}
                                type={"text"}
                                value={props.email} // TODO if username is email, pull it from login form instead of making user type it in again
                                onChange={props.onEmailChange}
                            />
                            <button type="submit" onClick={props.onSubmit} className="btn btn-default">Send Reset Email</button>
                        </div>
                        : <div>
                            <h4>Password reset sent to {props.email}</h4>
                        </div>
                }
            </div>
        </div>
    );
}

interface ForgotPasswordProps {
    email: string,
    onEmailChange: (event) => any,
    onSubmit: () => any,
    submitted: boolean
}