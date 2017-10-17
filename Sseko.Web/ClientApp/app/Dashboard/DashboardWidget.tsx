import 'react-bootstrap-daterangepicker/css/daterangepicker.css';
import * as React from 'react';
import * as ReactDOM from "react-dom";
import * as DateRangePicker from "react-bootstrap-daterangepicker";
import * as moment from 'moment';
import { DashboardSelectOption } from '../../components/DashboardSelectOption';
import C3Chart from 'react-c3js';
import 'c3/c3.css';

interface DashboardWidgetProps {
    dateFilter: { startDate: any, endDate: any };
}

interface DashboardWidgetState {
    startDate: any;
    endDate: any;
    ranges: any;
    minimize: boolean;
    close: boolean;
}

export class DashboardWidget extends React.Component<DashboardWidgetProps, DashboardWidgetState> {

    constructor(props) {
        super(props)
        this.state = {
            startDate: this.props.dateFilter.startDate,
            endDate: this.props.dateFilter.endDate,
            ranges: {
                'Today': [moment(), moment()],
                'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                'This Month': [moment().startOf('month'), moment().endOf('month')],
                'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            },
            minimize: false,
            close: false
        };
    }

    state = {
        startDate: null,
        endDate: null,
        ranges: null,
        minimize: false,
        close: false
    }

  
    onTransactionChange = (value) => {
        console.log("TransactionChange", value);
    }

    handleEvent = (event, picker) => {
        console.log("HandleEvent");
    }

    bodycollapse = (event) => {
        this.setState({ minimize: !this.state.minimize });
    }

    headcollapse = (event) => {
        this.setState({ close: !this.state.close });
    }

    render() {
        const start = this.state.startDate.format('YYYY-MM-DD');
        const end = this.state.endDate.format('YYYY-MM-DD');
        let label = start + ' - ' + end;
        if (start === end) {
            label = start;
        }
        const data = {
            x: 'x',
            columns: [
                ['x', '2017-01-01', '2017-02-01', '2017-03-01', '2017-04-01', '2017-05-01', '2017-06-01', '2017-07-01', '2017-08-01', '2017-09-01', '2017-10-01', '2017-11-01', '2017-12-01'],
                ['data1', 550, 650, 500, 800, 820, 650, 400, 500, 700, 650, 850, 900],
                ['data2', 400, 500, 350, 650, 670, 500, 250, 350, 550, 500, 700, 750],
                ['data3', 300, 400, 250, 550, 570, 400, 150, 250, 450, 400, 600, 650]
            ],
            types: {
                data1: 'area-spline',
                data2: 'area-spline',
                data3: 'area-spline'
            },
            colors: {
                data1: '#fca869',
                data2: '#febf8f',
                data3: '#fbd6bb'
            }
        };
        const color = {
            pattern: ['#fca869', '#febf8f', '#fbd6bb']
        };
        const axis = {
            x: {
                type: 'timeseries',
                tick: {
                    format: "%b",
                    fit: false
                }
            },
            y: {
                show: false
            }
        };
        const grid= {
            x: {
                show: true
            }
        }
        const legend= {
            show: false
        }
        return (
            <div className={"DashboardOptions" + (this.state.close ? " hideBody" : " showBody") }>
                <div className="DashboardHeader row">
                    <div className="pull-left widgetText">
                        <span className="headerTitle">Your Transactions</span>
                        <ul className="subList">
                            <li>
                                Commissions
                            </li>
                        </ul>
                    </div>
                    <div className="pull-right widgetIcon">
                        <i className="fa fa-minus" aria-hidden="true" onClick={this.bodycollapse}></i>
                        <i className="fa fa-times" aria-hidden="true" onClick={this.headcollapse}></i>
                    </div>
                </div>
                <div className={"DashboardBody row" + (this.state.minimize ? " hideBody" : " showBody")}>
                    <div className="DashboardSubBody row">
                        <div className="DashboardSelectOption">
                            <DashboardSelectOption options={transactionOptions}
                                initialValue={transactionOptions[0]}
                                onChange={this.onTransactionChange} />
                        </div>
                        <div className="DashboardSelectOption DateRangeOption">
                            <DateRangePicker
                                startDate={this.state.startDate}
                                endDate={this.state.endDate}
                                ranges={this.state.ranges}
                                onApply={this.handleEvent}
                                alwaysShowCalendars={true}
                                locale={{format: 'MM/DD/YYYY'}}

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
                    <div id="chartContainer" className="DashboardSubBody row">
                        <C3Chart data={data} color={color} axis={axis} grid={grid} legend={legend} />
                    </div>
                </div>
            </div>
        )
    }
}

const transactionOptions = [
    { value: 'Sales Transactions', label: 'Sales Transactions' },
    { value: 'Tier Transactions', label: 'Tier Transactions' },
    { value: 'All Transactions', label: 'All Transactions' }
];
