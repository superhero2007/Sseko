import * as React from 'react';
import { Label } from "./Label";
import { SelectList } from './SelectList';
import { DateSelect } from './DateSelect';
import { ButtonGroup } from './ButtonGroup';
import * as DateRangePicker from "react-bootstrap-daterangepicker";
import 'react-bootstrap-daterangepicker/css/daterangepicker.css';
import * as moment from 'moment';

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
    ranges: any;
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
            },
            ranges: {
                'Today': [moment(), moment()],
                'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                'This Month': [moment().startOf('month'), moment().endOf('month')],
                'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            }
        };
    }

    state = {
        startDate: null,
        endDate: null,
        selected: null,
        ranges: null
    }

    onSelectChange = (value) => {
        this.setState({ selected: value.value });
        this.props.onChange(value.value);
    }

    handleEvent= (event, picker) => {
        this.setState({
            startDate: picker.startDate,
            endDate: picker.endDate
        });
        this.props.onMonthChange(picker.startDate, picker.endDate);
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
                label={"Show Hostess"}
                options={this.props.hostesses}
                initialValue={this.props.init}
                clearable={false}
                onChange={this.onSelectChange}
            />
        const start = this.state.startDate.format('YYYY-MM-DD');
        const end = this.state.endDate.format('YYYY-MM-DD');
        let label = start + ' - ' + end;
        if (start === end) {
            label = start;
        }
        return (
            <div className="option">
                <div className="optionHeader">
                    <h3>{this.props.title}</h3>
                </div>
                <div className="optionBody">
                    <div className="leftLevel pull-left">
                        { left }
                    </div>
                    <div className="date pull-left">
                        <DateRangePicker
                            startDate={this.state.startDate}
                            endDate={this.state.endDate}
                            ranges={this.state.ranges}
                            onApply={this.handleEvent}
                        >
                            <button className="selected-date-range-btn">
                                <div className="pull-left"><i className="fa fa-calendar" aria-hidden="true"></i></div>
                                <div className="pull-right">
                                    <span>
                                        {label}
                                    </span>
                                    <span className="caret"></span>
                                </div>
                            </button>
                        </DateRangePicker>
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