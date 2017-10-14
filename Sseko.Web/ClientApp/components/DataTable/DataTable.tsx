import * as React from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
import { EmptyRowsView } from './EmptyRowsView';
import { LoadingView } from './LoadingView';
import 'react-bootstrap-table/dist/react-bootstrap-table.min.css';
declare let $: any;

interface DataTableProps {
    label?: string;
    rows: any,
    columns: any[],
    onGridSort: (column: string, dir: any) => any,
    isLoading: boolean,
}


function dataFormatter(cell, row) {
    return '<a>' + cell + '</a>';
}

function levelFormatter(cell, row) {
    if (cell == '1')
        return 'Little Sis';
    else if (cell == '2')
        return 'Niece';
    else if (cell == '3')
        return 'Granddaughter';
}


export class DataTable extends React.Component<DataTableProps, {}> {

    constructor(props) {
        super(props)
    }
    

    onGridSort(sortColumn, sortDir) {
        this.props.onGridSort(sortColumn, sortDir);
    }

    getTableWidth = () => {
        return this.props.columns.reduce((tableWidth, column) => tableWidth + column["width"], 0) + 34;
    }

    render() {
        // Logic for displaying headers for current rows
        const dataColumns = this.props.columns;
        const dataRows = this.props.rows;
        // Logic for displaying page numbers
        let paginationOption = null;
        if (this.props.rows.length != 0) {
        }
        else if (this.props.isLoading) {
            paginationOption = LoadingView();
        }
        else {
            paginationOption = EmptyRowsView();
        }

        const options = {
            exportCSVText: "Export",
            sizePerPage: 10,
            sizePerPageList: [10, 25, 50]
        };

        // Logic for displaying bodys for current rows
        let tableBody = null;
        const totalWidth = this.getTableWidth();
        if (this.props.rows.length != 0) {
            tableBody = (
                <BootstrapTable data={dataRows} options={options} exportCSV pagination search>
                    {
                        dataColumns.map(function (column, index) {
                            let icon = null;
                            if (column.sortable == 0)
                                icon = <i className="fa fa-sort" aria-hidden="true"></i>
                            else if (column.sortable == 1)
                                icon = <i className="fa fa-sort-asc" aria-hidden="true"></i>
                            else if (column.sortable == 2)
                                icon = <i className="fa fa-sort-desc" aria-hidden="true"></i>
                            if (column.key == "orderNumber") {
                                return (
                                    <TableHeaderColumn dataFormat={dataFormatter} dataField={column.key} key={column.key} isKey={index == 0 ? true : false} width={(column.width / totalWidth).toString() + '%'} dataSort={column.sortable != -1} ><span>{column.name}</span></TableHeaderColumn>
                                )
                            }
                            else if (column.key == "level") {
                                return (
                                    <TableHeaderColumn dataFormat={levelFormatter} dataField={column.key} key={column.key} isKey={index == 0 ? true : false} width={(column.width / totalWidth).toString() + '%'} dataSort={column.sortable != -1} ><span>{column.name}</span></TableHeaderColumn>
                                )
                            }
                            else if (column.key == "actions") {
                                return (
                                    <TableHeaderColumn dataFormat={column.formatter} dataField={column.key} key={column.key} isKey={index == 0 ? true : false} width={(column.width / totalWidth).toString() + '%'} dataSort={column.sortable != -1} ><span>{column.name}</span></TableHeaderColumn>
                                )
                            }
                            else {
                                return (
                                    <TableHeaderColumn dataField={column.key} key={column.key} isKey={index == 0 ? true : false} width={(column.width / totalWidth).toString() + '%'} dataSort={column.sortable != -1} ><span>{column.name}</span></TableHeaderColumn>
                                )
                            }
                        })
                    }
                </BootstrapTable>
            );
        }
        return (
            <div className="dataTable">
                {tableBody}
                {paginationOption}
            </div>
        );
    }
}
