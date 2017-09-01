import * as React from 'react';
import * as $ from 'jquery';
import * as ReactDataGrid from 'react-data-grid';
import EmptyRowsView from './EmptyRowsView';
import LoadingView from './LoadingView';

interface DataTableProps {
    label: string;
    rows: any,
    columns: any[],
    onGridSort: (column: string, dir: any) => any,
    isLoading: boolean,
}

const dataTableRowHeight = 35;
const dataTableRowHeaderHeight = 35;
const horizontalScrollbarHeight = 17;

export class DataTable extends React.Component<DataTableProps, {}> {
    constructor(props) {
        super(props);

        $(window).on("resize", () => {
            this.scale();
        });
    }

    componentDidUpdate = (nextProps) => {
        if (this.props.rows !== nextProps.rows){
            this.scale();
        }
    }

    componentDidMount = () => {
        this.scale();
    }

    scale = () => {
        $('.grid-container').each(function() {
            var scaled = $(this),
            parent = scaled.parent(),
            ratio = (parent.width() / scaled.width()),
            padding = scaled.height() * ratio;

            scaled.css({
                'transform': 'scale(' + ratio + ')',
                'transform-origin': 'top left'
            });

            //parent.css('padding-top', padding); // keeps the parent height in ratio to child resize
        })
    }

    rowGetter = (i) => {
        return this.props.rows[i];
    }

    getTableWidth = () => {
        let tableWidth = 0
        this.props.columns.map(column => { tableWidth += column["width"] });
        return tableWidth + 34;
    }

    render() {
        let tableWidth = this.getTableWidth()
        return (
                <div className="grid-container" style={{ width: tableWidth }}>
                    <div className="grid-label">{this.props.label}</div>
                    <ReactDataGrid
                        onGridSort={this.props.onGridSort}
                        columns={this.props.columns}
                        rowGetter={this.rowGetter}
                        rowsCount={this.props.rows.length}
                        rowHeight={35}
                        minWidth={tableWidth}
                        minHeight={Math.min(this.props.rows.length * dataTableRowHeight + dataTableRowHeaderHeight + horizontalScrollbarHeight)}
                        emptyRowsView={this.props.isLoading ? LoadingView : EmptyRowsView}
                    />
            </div>
        );
    }
}