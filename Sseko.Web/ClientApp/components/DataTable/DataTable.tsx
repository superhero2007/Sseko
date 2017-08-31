import * as React from 'react'
import * as ReactDataGrid from 'react-data-grid';
import { EmptyRowsView } from './EmptyRowsView';
import { LoadingView } from './LoadingView';

interface DataTableProps {
    rows: string[],
    columns: any[],
    onGridSort: (column: string, dir: any) => any,
    isLoading: boolean,
}

export class DataTable extends React.Component<DataTableProps, {}> {
    rowGetter = (i) => {
        return this.props.rows[i];
    }

    render() {
        return (
            <div>
                <div className="grid-label">{this.props.label}</div>
                <ReactDataGrid
                    onGridSort={this.props.onGridSort}
                    columns={this.props.columns}
                    rowGetter={this.rowGetter}
                    rowsCount={this.props.rows.length}
                    rowHeight={35}
                    minHeight={Math.min(this.props.rows.length * 35 + 35, 16 * 35)}
                    emptyRowsView={this.props.isLoading ? LoadingView : EmptyRowsView}
                />
            </div>
        );
    }
}