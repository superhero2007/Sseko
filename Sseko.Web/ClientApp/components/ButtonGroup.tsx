import 'react-select/dist/react-select.css';
import * as React from 'react';
import * as Select  from 'react-select';
import { Label } from './Label'

interface ButtonGroupProps {
    htmlId: string;
    name: string;
    options: any;
    label: string;
    onChange: (event: any) => any;
    error: string;
    initialValue?: string;
    multi?: boolean;
}

interface ButtonGroupState {
    values: number[];
}

// Drop-in replacement for SelectList
export class ButtonGroup extends React.Component<ButtonGroupProps, ButtonGroupState>  {
    // TODO maybe redeclare state
    componentWillMount() {
        let initialValue: Array<any> = this.props.initialValue.split(",");
        initialValue.pop();
        this.setState({ values: initialValue });
    }

    onValueChange = (value) => () => {
        let { values } = this.state;
        if (values.includes(value)) {
            values.splice(values.indexOf(value), 1);
        } else {
            values.push(value);
        }
        this.setState({ values });
        let onChangeValues = [];
        for (let v in values) {
            onChangeValues.push({ value: values[v] });
        }
        if (this.props.onChange != null)
            this.props.onChange({ value: onChangeValues });
    }

    buttons = () => {
        let buttons = [];
        for (let button in this.props.options) {
            let b = this.props.options[button];
            buttons.push(
                <button
                    className={"btn btn-primary" + (this.state.values.includes(b.value) ? " selected" : "")}
                    onClick={this.onValueChange(b.value)}
                    key={b.label}
                >
                    {b.label}
                </button>
            );
        }
        return buttons;
    }

    render() {
        return (
            <div className={"form-group section" + (this.props.error ? " has-danger" : "")}>
                <Label
                    htmlId={this.props.htmlId + "-label"}
                    label={this.props.label}
                />
                <br />
                <div className="btn-group" data-toggle="buttons-checkbox">
                    {this.buttons()}
                </div>
                {this.props.children}
                {this.props.error && <div className="form-control-feedback">{this.props.error}</div>}
            </div>
        )
    }
}