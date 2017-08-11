import * as React from 'react';
import { Textbox } from '../../components/Textbox';

export const ForgotPassword = (props: ForgotPasswordProps) => {
    return (
        <div>
            {
                !props.submitted
                    ? <div>
                        <Textbox
                            htmlId={"email-reset-input"}
                            label={"Email"}
                            name={"email"}
                            error={""}
                            type={"text"}
                            value={props.email}
                            onChange={props.onEmailChange}
                        />
                        <button type="submit" onClick={props.onSubmit} className="btn btn-default">Send Reset Email</button>
                    </div>
                    : <div>
                        <h4>Reset password set to {props.email}</h4>
                    </div>
            }
        </div>
    );
}

interface ForgotPasswordProps {
    email: string,
    onEmailChange: (event) => any,
    onSubmit: () => any,
    submitted: boolean
}