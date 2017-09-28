import * as React from 'react';
import * as moment from 'moment';
import ReactDatePicker from 'react-datepicker';
import { Label } from './Label'

import 'react-datepicker/dist/react-datepicker.css';
import '../css/datepicker.css';

interface DateSelectProps {
    htmlId: string,
    label: string,
    error: string
}

interface DateSelectState {
    startDate: Date,
    endDate: Date
}

export class DateSelect extends React.Component<DateSelectProps, DateSelectState> {

    constructor(props) {
        super(props)
        this.state = {
            startDate: moment(),
            endDate: moment().add(3, 'day')
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
    }

    handleChangeEnd = (date) => {
        this.setState({
            endDate: date
        });
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