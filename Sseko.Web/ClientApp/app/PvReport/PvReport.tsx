import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { SelectList } from '../../components/SelectList';
import { ButtonGroup } from '../../components/ButtonGroup';
import Total from '../../components/Totals/Total';
import TotalGroup from '../../components/Totals/TotalGroup';
import { Label } from "../../components/Label";
import balanceIcon = require('../../img/balance.png');
import personIcon = require('../../img/personal-volume.png');
import salesIcon = require('../../img/commissionable-sales.png');
import transactionsIcon = require('../../img/transaction.png');

export const PvReport = (props: PvReportProps) => {
    return (
        <Layout>
            <TotalGroup>
                <Total titleLabel={"FILTERED COMMISSIONABLE SALES"} mainContent={props.totalSales} />
                <Total titleLabel={"FILTERED TRANSACTIONS"} mainContent={props.totalTransactions} />
            </TotalGroup>
            <div className="row" id="filters">
                <div className="col-lg-4">
                    <SelectList
                        htmlId={"pvreport-month"}
                        name={""}
                        error={""}
                        label={"Time"}
                        //options={['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'].map((v, i) => ({ value: i, label: v }))}
                        options={timeOptions}
                        initialValue={timeOptions[1]}
                        onChange={props.onMonthChange}
                    />
                </div>
                <div className="col-lg-4">
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
                <div className="col-lg-4">
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
    );
}

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

const saleTypeOptions = [
    { value: 'Personal Purchase', label: 'Personal Purchase' },
    { value: 'Hostess Program', label: 'Hostess Program' },
    { value: 'Affiliate Sale', label: 'Affiliate Sale' },
    { value: 'Other', label: 'Other' }
];

const now = new Date();
const timeOptions = [
    {
        value: [new Date(0), new Date(now.getFullYear(), now.getMonth() + 1, 0)],
        label: "All time"
    },
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
    }
]