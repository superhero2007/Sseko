import * as React from 'react';
import * as ReactDOM from "react-dom";
import * as Highcharts from 'highcharts';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { Totals, Total } from '../../components/HelperTotals';
import { Header } from "../../components/Header";
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');


interface DashboardProps {
    dateFilter: { startDate: any, endDate: any };
    hasHostesses: boolean;
    hostesses: string[];
    hostessFilter: string;
    onGridSort: (sortColumn: string, sortDir: string) => any;
    onHostessChange: (event: any) => any;
    onMonthChange: (value1: any, value2: any) => any;
    onSaleTypeChange: (event: any) => any;
    rowGetter: (i: number) => any;
    rows: any;
    typeFilter: string;
    loading: boolean;
    totalSales: string;
    totalTransactions: number;
    totalPersonalVolume: string;
    columns: any;
}

export class Dashboard extends React.Component<DashboardProps, {}> {

    componentDidMount() {
        let myChart = Highcharts.chart('chartContainer', {
            chart: {
                type: 'area'
            },
            title: {
                text: ''
            },
            legend: {
                enabled: false
            },
            xAxis: {
                allowDecimals: false,
                labels: {
                    formatter: function () {
                        return this.value; // clean, unformatted number for year
                    }
                },
                tickWidth: 0,
                tickmarkPlacement: 'on',
                gridLineWidth: 1,
                gridZIndex: 4,
                lineWidth: 0,
                opposite: true,
                gridLineColor: '#e8a877',
                categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
            },
            yAxis: {
                title: {
                    text: ''
                },
                labels: {
                    formatter: function () {
                        return '';
                    }
                },
                gridLineWidth: 0
            },
            tooltip: {
                pointFormat: '{series.name} produced <b>{point.y:,.0f}</b><br/>warheads in {point.x}'
            },
            colors: ['#fca869', '#febf8f', '#fbd6bb'],
            plotOptions: {
                area: {
                    pointStart: 0,
                    marker: {
                        enabled: false,
                        symbol: 'circle',
                        radius: 5,
                        states: {
                            hover: {
                                enabled: true
                            }
                        }
                    },
                    fillOpacity: 1
                }
            },
            series: [{
                name: '1',
                data: [550, 650, 500, 800, 820, 650, 400, 500, 700, 650, 850, 900],
                color: '#fca869'
            }, {
                name: '2',
                data: [400, 500, 350, 650, 670, 500, 250, 350, 550, 500, 700, 750],
                color: '#febf8f'
            }, {
                name: '3',
                data: [300, 400, 250, 550, 570, 400, 150, 250, 450, 400, 600, 650],
                color: '#fbd6bb'
            }]
        });
    }
    
    public render() {
        

        return <Layout>
            <Header />
            <Totals>
                <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={this.props.totalPersonalVolume} />
                <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={this.props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"TOTAL TRANSACTIONS"} amount={this.props.totalTransactions} />
            </Totals>
            <div id="chartContainer">
            </div>
        </Layout>
    }
}
