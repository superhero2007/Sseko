import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { MonthPicker } from '../../components/MonthPicker/MonthPicker';
import { SelectList } from '../../components/SelectList';
import { ButtonGroup } from '../../components/ButtonGroup';
import balanceIcon = require('../../img/balance-ico.png');
import personIcon = require('../../img/personal-volume-ico.png');
import salesIcon = require('../../img/commissionable-sales-ico.png');
import transactionsIcon = require('../../img/transaction-ico.png');

const moneyFormat = (amount) =>
    "$" + amount.toFixed(0).replace(/(\d)(?=(\d{3})+$)/g, "$1,");

const moneyFormatDecimal = (amount) =>
    "$" + amount.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,");

const totalsBlock = (iconSrc, label, amount, money = true) =>
    <div className="totals-container">
        <img src={iconSrc}/>
        <span className="totals-label">
            {label}
            <br />
            <span title={money ? moneyFormatDecimal(amount) : null} className="totals-money">
                {money ? moneyFormat(amount) : amount}
            </span>
        </span>
    </div>;

export const PvReport = (props: PvReportProps) => {
    return (
        <Layout containerClassName="pvreport">
            <div className="totals">
                {totalsBlock(salesIcon, "TOTAL COMMISSIONABLE SALES", props.totalSales)}
                {totalsBlock(transactionsIcon, "TOTAL TRANSACTIONS", props.totalTransactions, false)}
            </div>
            <SelectList
                htmlId={"hostess-select"}
                name={"hostesses"}
                error={""}
                label={"Hostess"}
                onChange={props.onHostessChange}
                options={props.hostesses}
                initialValue={props.hostessFilter}
                multi
            />
            <div className="row">
                <div className="col-sm-2"> {/* TODO to auto width column */}
                    <MonthPicker
                        onChange={props.onMonthChange}
                        start={props.dateFilter.start}
                        end={props.dateFilter.end}
                    />
                </div>
                <div className="col-sm-10">
                    <ButtonGroup
                        htmlId={"program-select"}
                        name={"programs"}
                        error={""}
                        label={"Transaction Type"}
                        onChange={props.onSaleTypeChange}
                        options={saleTypeOptions}
                        initialValue={props.typeFilter}
                        multi
                    />
                </div>
            </div>
            <DataTable
                label="Personal Volume"
                rows={props.rows}
                columns={columns}
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
    rows: string[];
    typeFilter: string;
    loading: boolean;
    totalSales: number;
    totalTransactions: number;
}

const columns = [
    { key: 'date', name: 'DATE', width: 100, sortable: true },
    { key: 'orderNumber', name: 'ORDER #', width: 100, sortable: true },
    { key: 'customer', name: 'CUSTOMER', width: 200, sortable: true },
    { key: 'hostess', name: 'HOSTESS', width: 200, sortable: true },
    { key: 'type', name: 'TYPE', width: 200, sortable: true },
    { key: 'commission', name: 'COMMISSION', width: 125, sortable: true },
    { key: 'sale', name: 'TOTAL', width: 100, sortable: true }
];

const saleTypeOptions = [
    { value: 'Personal Purchase', label: 'Personal Purchase' },
    { value: 'Hostess Program', label: 'Hostess Program' },
    { value: 'Affiliate Sale', label: 'Affiliate Sale' },
    { value: 'Other', label: 'Other' }
]