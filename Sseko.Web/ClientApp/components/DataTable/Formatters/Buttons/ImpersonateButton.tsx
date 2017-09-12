import { Button } from './Button';
import * as React from 'react';

export class ImpersonateButton extends React.Component<ImpersonateButtonProps, {}> {
    render() {
        return (
            <Button
                htmlId={this.props.id + '-impersonate'}
                label={"Impersonate"}
                onClick={this.props.onImpersonate}
            />
        )
    }
}

interface ImpersonateButtonProps {
    id: string;
    onImpersonate: (any) => any;
}