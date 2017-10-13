import 'react-select/dist/react-select.css';
import * as React from 'react';
import * as Select from 'react-select';
interface DashboardSelectOptionProps {
    options: any,
    onChange: (event: any) => any,
    initialValue?: any
}

interface DashboardSelectOptionState {
    element: string;
    options?: Array<object>;
}

export class DashboardSelectOption extends React.Component<DashboardSelectOptionProps, DashboardSelectOptionState> {
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
            <div>
                <Select
                    options={this.state.options ? this.state.options : this.props.options}
                    onChange={this.onValueChange}
                    value={this.state.element}
                    clearable={false}
                    delimiter={','}
                />
            </div>
        )
    }
}