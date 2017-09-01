import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { MonthPicker } from '../../components/MonthPicker/MonthPicker';
import { SelectList } from '../../components/SelectList';
import { ButtonGroup } from '../../components/ButtonGroup';
import { Totals, Total } from '../../components/Totals';
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
            <SelectList
                htmlId={"hostess-select"}
                name={"hostesses"}
                error={""}
                label={"Search"}
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