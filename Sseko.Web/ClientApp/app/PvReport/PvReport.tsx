import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../Layout/Layout'
import { MonthPicker } from '../../components/MonthPicker';
import { SelectList } from '../../components/SelectList';

export const PvReport = (props: PvReportProps) => {
    return (
        <Layout>
            <MonthPicker
                onChange={props.onMonthChange}
                start={props.dateFilter.start}
                end={props.dateFilter.end}
            />
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
            <SelectList
                htmlId={"program-select"}
                name={"programs"}
                error={""}
                label={"Sale Type"}
                onChange={props.onSaleTypeChange}
                options={saleTypeOptions}
                initialValue={props.typeFilter}
                multi
            />
            <DataTable
                rows={props.rows}
                columns={columns}
                onGridSort={props.onGridSort}
            />
        </Layout>);
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
    rows: string[]
    typeFilter: string;
}

const columns = [
    { key: 'date', name: 'Date', width: 100, sortable: true },
    { key: 'orderNumber', name: 'Order No', width: 100, sortable: true },
    { key: 'customer', name: 'Customer', width: 200, sortable: true },
    { key: 'hostess', name: 'Hostess', width: 200, sortable: true },
    { key: 'type', name: 'Type', width: 200, sortable: true },
    { key: 'commission', name: 'Commission', width: 125, sortable: true },
    { key: 'sale', name: 'Total', width: 100, sortable: true }
];

const saleTypeOptions = [
    { value: 'Personal Purchase', label: 'Personal Purchase' },
    { value: 'Hostess Program', label: 'Hostess Program' },
    { value: 'Affiliate Sale', label: 'Affiliate Sale' },
    { value: 'Other', label: 'Other' }
]