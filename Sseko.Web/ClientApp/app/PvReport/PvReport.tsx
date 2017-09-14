import * as React from 'react';
import './PvReport.css';
import '../../css/grid.css';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { SelectList } from '../../components/SelectList';
import { ButtonGroup } from '../../components/ButtonGroup';
//import Total from '../../components/Totals/Total';
//import TotalGroup from '../../components/Totals/TotalGroup';
import { Totals, Total } from './HelperTotals';
import { Label } from "../../components/Label";
const balanceIcon = require<string>('../../img/balance.png');
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');

interface PvReportProps {
    dateFilter: { start: any, end: any };
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
    columns: any;
}

export const PvReport = (props: PvReportProps) =>
    <Layout>
        <Totals>
            <Total iconSrc={salesIcon} label={"FILTERED COMMISSIONABLE SALES"} amount={props.totalSales} />
            <Total iconSrc={transactionsIcon} label={"FILTERED TRANSACTIONS"} amount={props.totalTransactions} />
        </Totals>
        <div className="row" id="pv-filters">
            <div>
                <SelectList
                    htmlId={"pvreport-month"}
                    name={""}
                    error={""}
                    label={"Time"}
                    //options={['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'].map((v, i) => ({ value: i, label: v }))}
                    options={timeOptions}
                    initialValue={timeOptions[0]}
                    clearable={false}
                    onChange={props.onMonthChange}
                />
            </div>
            <div>
                <ButtonGroup
                    htmlId={"pvreport-transactiontype"}
                    name={"programs"}
                    error={""}
                    label={"Transaction Type"}
                    onChange={props.onSaleTypeChange}
                    options={saleTypeOptions}
                    initialValue={props.typeFilter}
                    multi
                />
            </div>
            <div>
                <SelectList
                    htmlId={"hostess-select"}
                    name={"hostesses"}
                    error={""}
                    label={"Hostess"}
                    onChange={props.onHostessChange}
                    options={props.hostesses}
                    multi
                />
            </div>
        </div>
        <DataTable
            label="Personal Volume"
            rows={props.rows}
            columns={props.columns}
            onGridSort={props.onGridSort}
            isLoading={props.loading}
        />
    </Layout>

const saleTypeOptions = [
    { value: 'Personal Purchase', label: 'Personal Purchase' },
    { value: 'Hostess Program', label: 'Hostess Program' },
    { value: 'Affiliate Sale', label: 'Affiliate Sale' },
    { value: 'Other', label: 'Other' }
];

const now = new Date();
const timeOptions = [
    {
        value: [new Date(now.getFullYear(), now.getMonth(), 1), new Date(now.getFullYear(), now.getMonth() + 1, 0)],
        label: "This month"
    },
    {
        value: [new Date(now.getFullYear(), now.getMonth() - 3, 1), new Date(now.getFullYear(), now.getMonth() + 1, 0)],
        label: "Last 3 months"
    },
    {
        value: [new Date(now.getFullYear(), now.getMonth() - 6, 1), new Date(now.getFullYear(), now.getMonth() + 1, 0)],
        label: "Last 6 months"
    },
    {
        value: [new Date(now.getFullYear(), 0, 0), new Date(now.getFullYear(), now.getMonth() + 1, 0)],
        label: "This year"
    },
    {
        value: [new Date(0), new Date(now.getFullYear(), now.getMonth() + 1, 0)],
        label: "All time"
    }
]