import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'
import { ButtonGroup } from '../../components/ButtonGroup';

export const DlReport = (props: DlReportProps) => {
    return (
        <Layout>
            <ButtonGroup
                htmlId={"level-select"}
                name={"levels"}
                error={""}
                label={"Levels"}
                onChange={props.onLevelChange}
                options={levelOptions}
                multi
                initialValue={props.levelFilter}
            />
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
    rowGetter: (i: number) => any;
    rows: string[],
    loading: boolean
}

const columns = [
    { key: 'fellow', name: 'Fellow', width: 150, sortable: true },
    { key: 'parent', name: 'Parent', width: 100, sortable: true },
    { key: 'grandparent', name: 'Grandparent', width: 125, sortable: true },
    { key: 'level', name: 'Level', width: 100, sortable: true },
    { key: 'commissionableSales', name: 'Commissionable Sales', width: 200, sortable: true },
    { key: 'pv', name: 'Total Sales', width: 125, sortable: true }
];

const levelOptions = [
    { value: '1', label: '1' },
    { value: '2', label: '2' },
    { value: '3', label: '3' }
];

