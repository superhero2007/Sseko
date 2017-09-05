﻿import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { MonthPicker } from '../../components/MonthPicker/MonthPicker';
import { SelectList } from '../../components/SelectList';
import { ButtonGroup } from '../../components/ButtonGroup';
import { Totals, Total } from '../../components/Totals';
import { Label } from "../../components/Label";
import balanceIcon = require('../../img/balance-ico.png');
import personIcon = require('../../img/personal-volume-ico.png');
import salesIcon = require('../../img/commissionable-sales-ico.png');
import transactionsIcon = require('../../img/transaction-ico.png');

export const PvReport = (props: PvReportProps) => {
    return (
        <Layout containerClassName="pvreport">
            <Totals>
                <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"TOTAL TRANSACTIONS"} amount={props.totalTransactions} money={false} />
            </Totals>
            <Label htmlId="" label="Filters" />
            <div className="row grid-sibling-row">
                <div className="col-sm-4">
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
                <div className="col-sm-4">
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
                <div className="col-sm-4">
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
    totalSales: number;
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