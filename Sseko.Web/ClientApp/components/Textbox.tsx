import * as React from 'react'
import { Label } from './Label'

interface TextboxProps {
    type: string,
    placeholder?: string
    htmlId: string,
    name: string,
    label: string,
    value: string,
    onChange: (event: any) => any,
    error: string
}

export class Textbox extends React.Component<TextboxProps, {}> {
    defaultProps: Partial<TextboxProps> = {
        placeholder: ''
    };
    render() {
        return (
            <div className={"form-group section" + (this.props.error ? " has-danger" : "")}>
                <Label
                    htmlId={this.props.htmlId + "-label"}
                    label={this.props.label || ""}
                />
                <input
                    id={this.props.htmlId}
                    type={this.props.type}
                    name={this.props.name}
                    placeholder={this.props.placeholder}
                    value={this.props.value}
                    onChange={this.props.onChange}
                    className={"form-control" + (this.props.error ? " form-control-danger" : "")}
                />
                {this.props.error && <div className="form-control-feedback">{this.props.error}</div>}
            </div>
        );
    }
}