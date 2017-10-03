import * as React from 'react';
import { Label } from "./Label";
import { SelectList } from './SelectList';
import { DateSelect } from './DateSelect';
import { ButtonGroup } from './ButtonGroup';

interface OptionProps {
    title: string;
    onChange: (value: any) => any;
    onMonthChange: (value1: any, value2: any) => any;
    startDate: any;
    endDate: any;
    hostesses: any;
    init: any;
}

interface OptionState {
    startDate: any;
    endDate: any;
    selected: any;
}

export class Option extends React.Component<OptionProps, OptionState> {

    constructor(props) {
        super(props)
        this.state = {
            startDate: this.props.startDate,
            endDate: this.props.endDate,
            selected: {
                value: "AllValue",
                label: "All"
            }
        };
    }

    state = {
        startDate: null,
        endDate: null,
        selected: null
    }

    onSelectChange = (value) => {
        console.log(value.value);
        this.setState({ selected: value.value});
    }

    onMonthChange = (value1, value2) => {
        this.setState({ startDate: value1, endDate: value2 });
    }

    applyChange = () => {
        this.props.onMonthChange(this.state.startDate, this.state.endDate);
        if (this.props.title == "Personal Volume")
            this.props.onChange(this.state.selected);
    }

    render() {
        let left = <ButtonGroup
            htmlId="level-select"
            name="levels"
            error=""
            label="Levels"
            onChange={this.props.onChange}
            options={levelOptions}
            multi
            initialValue={this.props.init}
        />
        if (this.props.title == "Personal Volume")
            left = <SelectList
                htmlId={"showLevel"}
                name={""}
                error={""}
                label={"Show Levels"}
                options={this.props.hostesses}
                initialValue={this.props.init}
                clearable={false}
                onChange={this.onSelectChange}
            />
        return (
            <div className="option">
                <div className="optionHeader">
                    <h3>{this.props.title}</h3>
                </div>
                <div className="optionBody">
                    <div className="showLevel pull-left">
                        { left }
                    </div>
                    <div className="date pull-left">
                        <DateSelect
                            htmlId={"dateRange"}
                            error={""}
                            label={"Date"}
                            onMonthChange={this.onMonthChange}
                            startDate={this.state.startDate}
                            endDate={this.state.endDate}
                        />
                    </div>
                    <div className="applyButton">
                        <button onClick={this.applyChange} >Apply</button>
                    </div>
                </div>
            </div>
        )
    }
}

const levelOptions = [
    { value: '1', label: '1' },
    { value: '2', label: '2' },
    { value: '3', label: '3' }
];