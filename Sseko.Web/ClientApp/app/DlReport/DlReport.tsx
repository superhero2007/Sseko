import * as React from 'react';
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
import '../../css/btn-3d.scss';

export const DlReport = (props: DlReportProps) => {
    return (
        <Layout>
            <Totals>
                <Total iconSrc={personIcon} label={"TOTAL PERSONAL VOLUME"} amount={props.totalPersonalVolume} />
                <Total iconSrc={salesIcon} label={"TOTAL COMMISSIONABLE SALES"} amount={props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"TOTAL FELLOWS"} amount={props.totalTransactions} />
            </Totals>
            <Option title="Downline Summary" hostesses={[]} onChange={props.onLevelChange} onMonthChange={props.onMonthChange} startDate={props.startDate} endDate={props.endDate} init={props.levelFilter} />
            <DataTable
                label="Downline Summary"
                rows={props.rows}
                onGridSort={props.onGridSort}
                columns={props.columns}
                isLoading={props.loading}
            />
        </Layout>
    )
}

interface DlReportProps {
    levelFilter: string[];
    onGridSort: (column: string, dir: string) => any;
    onLevelChange: (event: any) => any;
    rows: any[];
    columns: any;
    loading: boolean;
    totalSales: string;
    totalTransactions: number;
    totalPersonalVolume: string;
    onHostessChange: (value: any) => any;
    onMonthChange: (value1: any, value2: any) => any;
    startDate: any;
    endDate: any;
}

