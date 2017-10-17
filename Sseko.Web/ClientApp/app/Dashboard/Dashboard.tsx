import './Dashboard.css';
import * as React from 'react';
import * as ReactDOM from "react-dom";
import { Layout } from '../../components/Layout/Layout'
import { Totals, Total } from '../../components/HelperTotals';
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');
import { DashboardWidget } from './DashboardWidget';


interface DashboardProps {
    dateFilter: { startDate: any, endDate: any };
    onMonthChange: (value1: any, value2: any) => any;
    rows: any;
    loading: boolean;
    totalSales: string;
    totalTransactions: number;
    totalPersonalVolume: string;
}

export class Dashboard extends React.Component<DashboardProps, {}> {
    
    public render() {
        return <Layout>
            <Totals>
                <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={this.props.totalPersonalVolume} />
                <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={this.props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"TOTAL TRANSACTIONS"} amount={this.props.totalTransactions} />
            </Totals>
            <DashboardWidget dateFilter={this.props.dateFilter} onMonthChange={this.props.onMonthChange} />
        </Layout>
    }
}


