import * as React from 'react';
import './PvReport.css';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { SelectList } from '../../components/SelectList';
import { Totals, Total } from '../../components/HelperTotals';
import { Label } from "../../components/Label";
import { Option } from "../../components/Option";
const balanceIcon = require<string>('../../img/balance.png');
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');

interface PvReportProps {
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

export const PvReport = (props: PvReportProps) =>
    <Layout>
        <Totals>
            <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={props.totalPersonalVolume} />
            <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={props.totalSales} />
        </Totals>
        <Option title="Personal Volume" hostesses={props.hostesses} onChange={props.onHostessChange} onMonthChange={props.onMonthChange} startDate={props.dateFilter.startDate} endDate={props.dateFilter.endDate} init={props.hostesses[0]} />
        <DataTable
            label="Personal Volume"
            rows={props.rows}
            columns={props.columns}
            onGridSort={props.onGridSort}
            isLoading={props.loading}
        />
    </Layout>
