import * as React from 'react';
import './PvReport.css';
import '../../css/grid.scss';
import '../../css/btn-3d.scss';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { SelectList } from '../../components/SelectList';
import { ButtonGroup } from '../../components/ButtonGroup';
//import Total from '../../components/Totals/Total';
//import TotalGroup from '../../components/Totals/TotalGroup';
import { Totals, Total } from '../../components/HelperTotals';
import { Label } from "../../components/Label";
import { Header } from "../../components/Header";
import { Option } from "../../components/Option";
const balanceIcon = require<string>('../../img/balance.png');
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');

interface PvReportProps {
    dateFilter: { start: any, end: any };
    hasHostesses: boolean;
    hostesses: string[];
    hostessFilter: string;
    onGridSort: (sortColumn: string, sortDir: string) => any;
    onHostessChange: (event: any) => any;
    onMonthChange: (value: any) => any;
    onSaleTypeChange: (event: any) => any;
    rowGetter: (i: number) => any;
    rows: any;
    typeFilter: string;
    loading: boolean;
    totalSales: string;
    totalTransactions: number;
    totalPersonalVolume: string;
    balance: string;
    columns: any;
}

export const PvReport = (props: PvReportProps) =>
    <Layout>
        <Header />
        <Totals>
            <Total iconSrc={balanceIcon} label={"BALANCE"} amount={props.balance} />
            <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={props.totalPersonalVolume} />
            <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={props.totalSales} />
            <Total iconSrc={transactionsIcon} label={"TOTAL TRANSACTIONS"} amount={props.totalTransactions} />
        </Totals>
        <Option title="Personal Volume" onMonthChange={props.onMonthChange} />
        <DataTable
            label="Personal Volume"
            rows={props.rows}
            columns={props.columns}
            onGridSort={props.onGridSort}
            isLoading={props.loading}
        />
    </Layout>
