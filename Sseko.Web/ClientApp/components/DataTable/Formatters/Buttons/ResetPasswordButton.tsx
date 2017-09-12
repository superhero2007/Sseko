import { Button } from './Button';
import * as React from 'react';

export class ResetPasswordButton extends React.Component<ResetButtonProps, {}> {
    render() {
        return (
            <Button
                htmlId={this.props.id + '-reset-password'}
                label={"Reset Password"}
                onClick={this.props.onReset}
            />
        )
    }
}

interface ResetButtonProps {
    id: string;
    onReset: (any) => any;
}