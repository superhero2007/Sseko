import * as React from 'react';

export class Button extends React.Component<ButtonProps, {}> {
    render() {
        return (
            <button
                id={this.props.htmlId}
                className="btn btn-default"
                role="button"
                onClick={this.props.onClick}>
                {this.props.label}
            </button>
        )
    }
}

interface ButtonProps {
    htmlId: string;
    onClick: (any) => any;
    label: string;
}