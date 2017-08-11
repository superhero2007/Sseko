import * as React from 'react';
import { Link } from 'react-router-dom'
import { Textbox } from '../../components/Textbox';

export const ResetPassword = (props: ResetPasswordProps) => {
    const { submitError, errors, auth, onChange, onSubmit, submitted } = props;
    return (
        <div>
            {
                !submitted
                    ? <div>
                        <div>
                            <h1>Reset Password</h1>
                            {submitError && <div className="alert alert-danger">{submitError}</div>}
                        </div>
                        <Textbox
                            htmlId={"password-reset-input"}
                            label={"Pasword"}
                            name={"password"}
                            error={errors.password}
                            type={"text"}
                            value={auth.password}
                            onChange={onChange}
                        />
                        <Textbox
                            htmlId={"password-confirmation-input"}
                            label={"Pasword Confirmation"}
                            name={"passwordConfirmation"}
                            error={errors.passwordConfirmation}
                            type={"text"}
                            value={auth.passwordConfirmation}
                            onChange={onChange}
                        />
                        <button type="submit" onClick={onSubmit} className="btn btn-default">Reset Password</button>
                    </div>
                    : <div>
                        <h2>Password Reset!</h2>
                        <Link to={"/Login"}>Click here to login</Link>
                    </div>
            }
        </div>
    );
}

interface ResetPasswordProps {
    onChange: (event) => any;
    onSubmit: () => any;
    auth: { password: string, passwordConfirmation: string };
    errors: any,
    submitError: string,
    submitted: boolean
}