import { Button } from './Button';
import * as React from 'react';

export class DisableButton extends React.Component<DisableButtonProps, {}> {
    render() {
        return (
            <Button
                htmlId={this.props.id + '-disable'}
                label={"Disable"}
                onClick={this.props.onDisable}
            />
        )
    }
}

interface DisableButtonProps {
    id: string;
    onDisable: (any) => any;
}