import * as React from 'react'

interface LabelProps {
    htmlId: string,
    label: string,
    required: boolean
}

export class Label extends React.Component<LabelProps, {}> {
    render() {
        return (
            <label className={"h4 section-heading"} id={this.props.htmlId} >
                {this.props.label} {this.props.required && <span className="text-danger"> *</span>}
            </label>
        );
    }
}
