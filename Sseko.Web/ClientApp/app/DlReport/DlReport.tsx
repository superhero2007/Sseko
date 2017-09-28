import * as React from 'react';
import '../../css/grid.scss';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { ButtonGroup } from '../../components/ButtonGroup';
import { Totals, Total } from '../../components/HelperTotals';
import { Label } from "../../components/Label";
import { Header } from "../../components/Header";
import { Option } from "../../components/Option";
const balanceIcon = require<string>('../../img/balance.png');
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');

export const DlReport = (props: DlReportProps) => {
    return (
        <Layout>
            <Header />
            <Totals>
                <Total iconSrc={balanceIcon} label={"BALANCE"} amount={props.balance} />
                <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={props.totalPersonalVolume} />
                <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"TOTAL TRANSACTIONS"} amount={props.totalTransactions} />
            </Totals>
            <Option title="Downline Summary" onMonthChange={props.onMonthChange} />
            <DataTable
                label="Downline Summary"
                rows={props.rows}
                onGridSort={props.onGridSort}
                columns={columns}
                isLoading={props.loading}
            />
        </Layout>
    )
}

interface DlReportProps {
    levelFilter: string;
    onGridSort: (column: string, dir: string) => any;
    onLevelChange: (event: any) => any;
    rows: any[];
    loading: boolean;
    totalSales: string;
    totalTransactions: number;
    totalPersonalVolume: string;
    balance: string;
    onMonthChange: (value: any) => any;
}

const columns = [
    { key: 'fellow', name: 'Fellow', width: 150, sortable: true },
    { key: 'parent', name: 'Parent', width: 100, sortable: true },
    { key: 'grandparent', name: 'Grandparent', width: 125, sortable: true },
    { key: 'level', name: 'Level', width: 100, sortable: true },
    { key: 'commissionableSales', name: 'Commissionable Sales', width: 200, sortable: true },
    { key: 'pv', name: 'Total Sales', width: 125, sortable: true }
];
