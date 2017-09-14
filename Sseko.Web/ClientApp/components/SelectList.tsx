import 'react-select/dist/react-select.css';
import * as React from 'react';
import * as Select from 'react-select';
import { Label } from './Label'

interface SelectListProps {
    htmlId: string,
    name: string,
    options: any,
    label: string,
    onChange: (event: any) => any,
    error: string,
    initialValue?: any,
    multi?: boolean,
    clearable?: boolean
}

interface SelectListState {
    element: string;
    options?: Array<object>;
}

export class SelectList extends React.Component<SelectListProps, SelectListState> {
    constructor(props) {
        super(props)

        if (props.options[0] && !props.options[0].label) {
            // this is a list of strings "value"; transform it into a list of objects {"value", "label"}
            this.state = { element: this.props.initialValue, options: props.options.map(o => ({ value: o, label: o })) };
        } else {
            this.state = { element: this.props.initialValue, options: null };
        }
    }

    state = {
        element: null,
        options: null
    }

    onValueChange = (value, label) => {
        this.setState(() => ({
            element: value
        }));
        if (this.props.onChange != null)
            this.props.onChange({ value: value });
    }

    render() {
        return (
            <div className={"form-group section" + (this.props.error ? " has-danger" : "")}>
                <Label
                    htmlId={this.props.htmlId + "-label"}
                    label={this.props.label}
                />
                <Select
                    name={this.props.name}
                    options={this.state.options ? this.state.options : this.props.options}
                    onChange={this.onValueChange}
                    value={this.state.element}
                    className={(this.props.error ? "form-control-danger" : "")}
                    multi={this.props.multi}
                    clearable={this.props.clearable || false}
                    delimiter={','}
                />
                {this.props.children}
                {this.props.error && <div className="form-control-feedback">{this.props.error}</div>}
            </div>
        )
    }
}