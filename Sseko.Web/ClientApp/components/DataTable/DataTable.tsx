import * as React from 'react';
import { BootstrapTable, TableHeaderColumn } from 'react-bootstrap-table';
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

interface DataTableState {
    currentPage: number,
    todosPerPage: number
}


function dataFormatter(cell, row) {
    return '<a>' + cell + '</a>';
}


export class DataTable extends React.Component<DataTableProps, DataTableState> {

    constructor(props) {
        super(props)
        this.state = {
            currentPage: 1,
            todosPerPage: 10
        };
        this.handleClick = this.handleClick.bind(this);
    }

    state = {
        currentPage: 1,
        todosPerPage: 10
    }

    onGridSort(sortColumn, sortDir) {
        this.props.onGridSort(sortColumn, sortDir);
    }

    handleClick(event) {
        this.setState({
            currentPage: Number(event.target.id)
        });
    }

    getTableWidth = () => {
        return this.props.columns.reduce((tableWidth, column) => tableWidth + column["width"], 0) + 34;
    }

    render() {
        const { currentPage, todosPerPage } = this.state;

        // Logic for displaying headers for current rows
        const indexOfLastTodo = currentPage * todosPerPage;
        const indexOfFirstTodo = indexOfLastTodo - todosPerPage;
        const dataColumns = this.props.columns;
        const dataRows = this.props.rows.slice(indexOfFirstTodo, indexOfLastTodo);

        const options = {
            exportCSVText: "Export"
        };

        // Logic for displaying bodys for current rows
        let tableBody = null;
        if (this.props.rows.length != 0) {
            tableBody = (
                <BootstrapTable data={dataRows} options={options} exportCSV>
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
                                    <TableHeaderColumn dataFormat={dataFormatter} dataField={column.key} key={column.key} isKey={index == 0 ? true : false} width={column.width.toString()} dataSort={column.sortable != -1} ><span>{column.name}</span></TableHeaderColumn>
                                )
                            }
                            else {
                                return (
                                    <TableHeaderColumn dataField={column.key} key={column.key} isKey={index == 0 ? true : false} width={column.width.toString()} dataSort={column.sortable != -1} ><span>{column.name}</span></TableHeaderColumn>
                                )
                            }
                        })
                    }
                </BootstrapTable>
            );
        }

        // Logic for displaying page numbers
        const pageNumbers = [];
        for (let i = 1; i <= Math.ceil(this.props.rows.length / todosPerPage); i++) {
            pageNumbers.push(i);
        }

        const renderPageNumbers = pageNumbers.map(number => {
            return (
                <li
                    key={number}
                    id={number}
                    onClick={this.handleClick}
                    className={currentPage == number ? "active" : ""}
                >
                    {number}
                </li>
            );
        });

        let paginationOption = null;
        if (this.props.rows.length != 0) {
            paginationOption = (<div className="paginationOption">
                <span className="pull-left">Showing {indexOfFirstTodo + 1}-{indexOfLastTodo < this.props.rows.length ? indexOfLastTodo : this.props.rows.length} of {this.props.rows.length}</span>
                <ul id="page-numbers">
                    {renderPageNumbers}
                </ul>
                <span className="pull-right page-label"> Page: </span>
            </div>);
        }
        else if (this.props.isLoading) {
            paginationOption = LoadingView();
        }
        else {
            paginationOption = EmptyRowsView();
        }

        const tableWidth = this.getTableWidth()

        return (
            <div className="dataTable">
                {tableBody}
                {paginationOption}
            </div>
        );
    }
}
