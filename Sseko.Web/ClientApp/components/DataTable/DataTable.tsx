import * as React from 'react'
import * as ReactDataGrid from 'react-data-grid';
import {EmptyRowsView} from './EmptyRowsView';

interface DataTableProps {
    rows: string[],
    columns: any[],
    onGridSort: (column: string, dir: any) => any
}

export class DataTable extends React.Component<DataTableProps, {}> {

    rowGetter = (i) => {
        return this.props.rows[i];
    }

    render() {
        return (
            <ReactDataGrid
                onGridSort={this.props.onGridSort}
                columns={this.props.columns}
                rowGetter={this.rowGetter}
                rowsCount={this.props.rows.length}
                emptyRowsView={EmptyRowsView}
            />
        );
    }
}