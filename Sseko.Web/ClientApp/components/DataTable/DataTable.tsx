import * as React from 'react';
import * as ReactDataGrid from 'react-data-grid';
import { EmptyRowsView } from './EmptyRowsView';
import { LoadingView } from './LoadingView';

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
    constructor(props) {
        super(props);

        //$(window).on("resize", () => {
        //    this.scale();
        //});

        // throttle resize events
        var running = false;
        window.addEventListener("resize", () => {
            if (running) { return; }
            running = true;
            requestAnimationFrame(function () {
                window.dispatchEvent(new CustomEvent("optimizedResize"));
                running = false;
            });
        });

        const scale = this.scale;
        window.addEventListener("optimizedResize", function () {
            scale();
        });
    }

    componentDidUpdate(nextProps) {
        if (this.props.rows !== nextProps.rows) {
            this.scale();
        }
    }

    componentDidMount() {
        this.scale();
    }

    // resize datatable
    scale = () => {
        $('.grid-container').each(function () { // TODO remove jquery
            var scaled = $(this),
                parent = scaled.parent(),
                ratio = parent.width() / scaled.width(),
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
        return this.props.columns.reduce((tableWidth, column) => tableWidth + column["width"], 0) + 34;
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
                    rowHeight={32}
                    headerRowHeight={32}
                    minWidth={tableWidth}
                    minHeight={Math.min(this.props.rows.length * dataTableRowHeight + dataTableRowHeaderHeight + horizontalScrollbarHeight)}
                    emptyRowsView={this.props.isLoading ? LoadingView : EmptyRowsView}
                />
            </div>
        );
    }
}