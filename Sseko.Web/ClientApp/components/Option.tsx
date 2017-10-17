import * as React from 'react';
import { Label } from "./Label";
import { SelectList } from './SelectList';
import { DateSelect } from './DateSelect';
import { ButtonGroup } from './ButtonGroup';
import 'react-monthrange-picker/src/css/monthly_picker.css';
import * as ReactMonthRangePicker from 'react-monthrange-picker';
import * as moment from 'moment';
import { extendMoment } from 'moment-range';
const Moment = extendMoment(moment);

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
    selected: any;
    ranges: any;
}

export class Option extends React.Component<OptionProps, OptionState> {

    constructor(props) {
        super(props)
        this.state = {
            selected: {
                value: "AllValue",
                label: "All"
            },
            ranges: {
                'Month To Date': [moment().startOf('month'), moment()],
                'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')],
                '2 Months ago': [moment().subtract(2, 'month').startOf('month'), moment().subtract(2, 'month').endOf('month')],
                '3 Months ago': [moment().subtract(3, 'month').startOf('month'), moment().subtract(3, 'month').endOf('month')]
            }
        };
    }

    state = {
        selected: null,
        ranges: null
    }

    onSelectChange = (value) => {
        this.setState({ selected: value.value });
        this.props.onChange(value.value);
    }

    handleEvent = (value) => {
        this.props.onMonthChange(value.start, value.end);
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
                        <ReactMonthRangePicker
                            selectedDateRange={Moment.range(this.props.startDate, this.props.endDate)}
                            onApply={this.handleEvent}
                            direction={"bottom"}
                        />
                    </div>
                </div>
            </div>
        )
    }
}

const levelOptions = [
    { value: '1', label: 'Little Sis' },
    { value: '2', label: 'Nieces' },
    { value: '3', label: 'Granddaughters' }];