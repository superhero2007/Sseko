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
    initialValue?: string[];
    multi?: boolean;
}

interface ButtonGroupState {
    values: string[];
}

// Drop-in replacement for SelectList
export class ButtonGroup extends React.Component<ButtonGroupProps, ButtonGroupState>  {
    // TODO maybe redeclare state
    componentWillMount() {
        this.setState({ values: this.props.initialValue });
    }

    onValueChange = (value) => () => {
        let { values } = this.state;
        if (value != "4") {
            if (values.includes(value)) {
                values.splice(values.indexOf(value), 1);
            } else {
                values.push(value);
            }
        }
        else {
            if (values.length != 3)
                values = ["1", "2", "3"];
            else
                values = [];
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
                    className={"btn-3d btn-primary" + (this.state.values.includes(b.value) ? " selected" : "")}
                    onClick={this.onValueChange(b.value)}
                    key={b.label}
                >
                    <span><span>{b.label}</span></span>
                </button>
            );
        }
        buttons.push(
            <button
                className={"btn-3d btn-primary" + (this.state.values.length == 3 ? " selected" : "")}
                onClick={this.onValueChange("4")}
                key={"All"}
            >
                <span><span>All</span></span>
            </button>
        );
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