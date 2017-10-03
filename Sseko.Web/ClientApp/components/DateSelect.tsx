import * as React from 'react';
import ReactDatePicker from 'react-datepicker';
import { Label } from './Label'

import 'react-datepicker/dist/react-datepicker.css';
import '../css/datepicker.css';

interface DateSelectProps {
    htmlId: string,
    label: string,
    error: string,
    onMonthChange: any,
    startDate: any,
    endDate: any
}

interface DateSelectState {
    startDate: Date,
    endDate: Date
}

export class DateSelect extends React.Component<DateSelectProps, DateSelectState> {

    constructor(props) {
        super(props)
        this.state = {
            startDate: this.props.startDate,
            endDate: this.props.endDate
        };
    }

    state = {
        startDate: null,
        endDate: null
    }

    handleChangeStart = (date) => {
        this.setState({
            startDate: date
        });
        this.props.onMonthChange(date, this.state.endDate);
    }

    handleChangeEnd = (date) => {
        this.setState({
            endDate: date
        });
        this.props.onMonthChange(this.state.startDate, date);
    }

    render() {
        return (
            <div className={"form-group section" + (this.props.error ? " has-danger" : "")}>
                <Label
                    htmlId={this.props.htmlId + "-label"}
                    label={this.props.label}
                />
                <div className="dateRange">
                    <div className="pull-left">
                        <ReactDatePicker
                            selected={this.state.startDate}
                            selectsStart
                            startDate={this.state.startDate}
                            endDate={this.state.endDate}
                            onChange={this.handleChangeStart}
                            dateFormat="MM/DD/YY"
                        />
                    </div>
                    <div className="pull-left dateTo">
                        <span> to </span>
                    </div>
                    <div className="pull-left">
                        <ReactDatePicker
                            selected={this.state.endDate}
                            selectsEnd
                            startDate={this.state.startDate}
                            endDate={this.state.endDate}
                            onChange={this.handleChangeEnd}
                            dateFormat="MM/DD/YY"
                        />
                    </div>
                </div>
                {this.props.children}
                {this.props.error && <div className="form-control-feedback">{this.props.error}</div>}
            </div>
        )
    }
}