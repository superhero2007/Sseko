import * as React from 'react';
import * as ReactDataGrid from 'react-data-grid';
import { EmptyRowsView } from './EmptyRowsView';
import { LoadingView } from './LoadingView';
declare let $: any;

interface DataTableProps {
    label?: string;
    rows: any,
    columns: any[],
    onGridSort: (column: string, dir: any) => any,
    isLoading: boolean,
}

const dataTableRowHeight = 35;
const dataTableRowHeaderHeight = 35;
const horizontalScrollbarHeight = 17;

export class DataTable extends React.Component<DataTableProps, {}> {
    rowGetter = (i) => {
        return this.props.rows[i];
    }

    render() {
        return (
            <div className="grid-container">
                <ReactDataGrid
                    onGridSort={this.props.onGridSort}
                    columns={this.props.columns}
                    rowGetter={this.rowGetter}
                    rowsCount={this.props.rows.length}
                    rowHeight={32}
                    headerRowHeight={32}
                    minHeight={Math.min(this.props.rows.length * dataTableRowHeight + dataTableRowHeaderHeight + horizontalScrollbarHeight)}
                    emptyRowsView={this.props.isLoading ? LoadingView : EmptyRowsView}
                />
            </div>
        );
    }
}