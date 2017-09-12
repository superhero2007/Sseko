import { Button } from './Button';
import * as React from 'react';

export class EnableButton extends React.Component<EnableButtonProps, {}> {
    render() {
        return (
            <Button
                htmlId={this.props.id + '-enable'}
                label={"Enable"}
                onClick={this.props.onEnable}
            />
        )
    }
}

interface EnableButtonProps {
    id: string;
    onEnable: (any) => any;
}