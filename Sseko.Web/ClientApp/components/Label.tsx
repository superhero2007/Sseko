import * as React from 'react'

interface LabelProps {
    htmlId: string,
    label: string
}

export class Label extends React.PureComponent<LabelProps, {}> {
    render() {
        return (
            <label className={"h4 section-heading"} id={this.props.htmlId}>
                {this.props.label}
            </label>
        );
    }
}
