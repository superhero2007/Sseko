import 'react-bootstrap-daterangepicker/css/daterangepicker.css';
import * as React from 'react';
import * as ReactDOM from "react-dom";
import * as DateRangePicker from "react-bootstrap-daterangepicker";
import * as moment from 'moment';
import { DashboardSelectOption } from '../../components/DashboardSelectOption';

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

    //componentDidMount() {
    //    let myChart = Highcharts.chart('chartContainer', {
    //        chart: {
    //            type: 'areaspline'
    //        },
    //        title: {
    //            text: ''
    //        },
    //        legend: {
    //            enabled: false
    //        },
    //        xAxis: {
    //            allowDecimals: false,
    //            labels: {
    //                formatter: function () {
    //                    return this.value; // clean, unformatted number for year
    //                }
    //            },
    //            tickWidth: 0,
    //            tickmarkPlacement: 'on',
    //            gridLineWidth: 1,
    //            gridZIndex: 4,
    //            lineWidth: 0,
    //            opposite: true,
    //            gridLineColor: '#e8a877',
    //            categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
    //        },
    //        yAxis: {
    //            title: {
    //                text: ''
    //            },
    //            labels: {
    //                formatter: function () {
    //                    return '';
    //                }
    //            },
    //            gridLineWidth: 0
    //        },
    //        tooltip: {
    //            pointFormat: '{series.name} produced <b>{point.y:,.0f}</b><br/>warheads in {point.x}'
    //        },
    //        colors: ['#fca869', '#febf8f', '#fbd6bb'],
    //        plotOptions: {
    //            areaspline: {
    //                pointStart: 0,
    //                marker: {
    //                    enabled: false,
    //                    symbol: 'circle',
    //                    radius: 5,
    //                    states: {
    //                        hover: {
    //                            enabled: true
    //                        }
    //                    }
    //                },
    //                fillOpacity: 1
    //            }
    //        },
    //        series: [{
    //            name: '1',
    //            data: [550, 650, 500, 800, 820, 650, 400, 500, 700, 650, 850, 900],
    //            color: '#fca869'
    //        }, {
    //            name: '2',
    //            data: [400, 500, 350, 650, 670, 500, 250, 350, 550, 500, 700, 750],
    //            color: '#febf8f'
    //        }, {
    //            name: '3',
    //            data: [300, 400, 250, 550, 570, 400, 150, 250, 450, 400, 600, 650],
    //            color: '#fbd6bb'
    //        }]
    //    });
    //}

    onTransactionChange = (value) => {
        console.log("TransactionChange", value);
    }

    onDateChange = (value) => {
        console.log("DateChange", value);
    }

    onFellowChange = (value) => {
        console.log("FellowChange", value);
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
                        <div className="DashboardSelectOption">
                            <DashboardSelectOption options={dateOptions}
                                initialValue={dateOptions[0]}
                                onChange={this.onDateChange} />
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
                        <div className="DashboardSelectOption">
                            <DashboardSelectOption options={fellowOptions}
                                initialValue={fellowOptions[0]}
                                onChange={this.onFellowChange} />
                        </div>
                        <div className="DashboardSelectOption DashboardLegendButton">
                            <button className="legendButton"> Legends </button>
                        </div>
                    </div>
                    <div id="chartContainer" className="DashboardSubBody row">
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

const dateOptions = [
    { value: 'Yearly', label: 'Yearly' }
];

const fellowOptions = [
    { value: 'Show All', label: 'Show All' },
    { value: 'Only Me', label: 'Only Me' },
    { value: 'Me and Fellows Tiers', label: 'Me and Fellows Tiers' }
];