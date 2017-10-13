import './Dashboard.css';
import * as React from 'react';
import * as ReactDOM from "react-dom";
import { Layout } from '../../components/Layout/Layout'
import { Totals, Total } from '../../components/HelperTotals';
import { Header } from "../../components/Header";
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');
import { DashboardWidget } from './DashboardWidget';

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
    
    public render() {
        return <Layout>
            <Header />
            <Totals>
                <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={this.props.totalPersonalVolume} />
                <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={this.props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"TOTAL TRANSACTIONS"} amount={this.props.totalTransactions} />
            </Totals>
            <DashboardWidget dateFilter={this.props.dateFilter} />
        </Layout>
    }
}


