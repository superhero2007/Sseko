import 'react-select/dist/react-select.css';
import * as React from 'react';
import * as Select  from 'react-select';
import { Label } from './Label'

interface SelectListProps {
    htmlId: string,
    name: string,
    options: any,
    label: string,
    onChange: (event: any) => any,
    error: string,
    initialValue?: string,
    required?: boolean,
    multi?: boolean
}

interface SelectListState {
    element: string
}

export class SelectList extends React.Component<SelectListProps, SelectListState>  {
    state = {
        element: null
    }

    componentWillMount = () => {
        this.setState({ element: this.props.initialValue });
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
                    required={this.props.required}
                />
                <Select
                    name={this.props.name}
                    options={this.props.options}
                    onChange={this.onValueChange}
                    value={this.state.element}
                    className={(this.props.error ? "form-control-danger" : "")}
                    multi={this.props.multi}
                    delimiter={','}
                />
                {this.props.children}
                {this.props.error && <div className="form-control-feedback">{this.props.error}</div>}
            </div>
        )
    }
}