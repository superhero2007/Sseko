import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { ButtonGroup } from '../../components/ButtonGroup';
import { Totals, Total } from '../../components/HelperTotals';
import { Label } from "../../components/Label";
import { Option } from "../../components/Option";
const balanceIcon = require<string>('../../img/balance.png');
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');
import '../../css/btn-3d.scss';

export const DlReport = (props: DlReportProps) => {
    let commonlabel = '';
    for (let i = 0; i < props.levelFilter.length; i++) {
        if (commonlabel != '')
            commonlabel += ' and ';
        if (props.levelFilter[i] == '1')
            commonlabel += 'Little Sis';
        else if (props.levelFilter[i] == '2')
            commonlabel += 'Niece';
        else if (props.levelFilter[i] == '3')
            commonlabel += 'Granddaughter';
    }
    if (props.levelFilter.length == 3 || props.levelFilter.length == 0)
        commonlabel = 'Family'
    return (
        <Layout>
            <Totals>
                <Total iconSrc={personIcon} label={"Total " + commonlabel + " Volume"} amount={props.totalPersonalVolume} />
                <Total iconSrc={salesIcon} label={"Total " + commonlabel + " Commissionable Sales"} amount={props.totalSales} />
                <Total iconSrc={transactionsIcon} label={"Total " + commonlabel + " Fellows"} amount={props.totalTransactions} />
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

