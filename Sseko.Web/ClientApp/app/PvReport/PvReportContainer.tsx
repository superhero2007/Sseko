import * as React from 'react';
import * as Report from './PvReportStore';
import { ApplicationState } from '../../store';
import { connect } from 'react-redux';
import { PvReport } from './PvReport';
import { sortGrid, typeFilterer, hostessFilterer, dateFilterer } from '../../utils/DatatableFilters';
import { Formatters } from '../../utils/Formatters'

type PvReportProps = MappedProps & typeof Report.actionCreators;

class PvReportContainer extends React.Component<PvReportProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.rows.length == 0)
            this.props.getPvReport();

        this.onGridSort = this.onGridSort.bind(this);
        this.rowGetter = this.rowGetter.bind(this);
        this.onSaleTypeChange = this.onSaleTypeChange.bind(this);
        this.onHostessChange = this.onHostessChange.bind(this);
        this.onMonthChange = this.onMonthChange.bind(this);
        this.calculateTotalSales = this.calculateTotalSales.bind(this);
    }

    getColumns = () => {
        let columns = [
            { key: 'date', name: 'DATE', sortable: true },
            { key: 'orderNumber', name: 'ORDER #', sortable: true },
            { key: 'customer', name: 'CUSTOMER', sortable: true },
            { key: 'hostess', name: 'HOSTESS', sortable: true },
            { key: 'type', name: 'TYPE', sortable: true },
            { key: 'commission', name: 'CS', sortable: true },
            { key: 'sale', name: 'TOTAL', sortable: true }
        ];
        // Calculate column widths based on character counts
        for (let c in columns) {
            // Magic numbers
            let headerCharacterWidth = 13;
            let rowItemCharacterWidth = 8;
            let headerPadding = 15;
            let rowPadding = 15;
            let sortable = 18;
            //

            let headerWidth = columns[c]["name"].length * headerCharacterWidth + headerPadding + (columns[c]["sortable"] ? sortable : 0);

            // Find the widest row item
            let maxRowWidth = headerWidth;
            this.props.rows.map(row => {
                maxRowWidth = Math.max(maxRowWidth, row[columns[c].key].length * rowItemCharacterWidth + rowPadding);
            });
            columns[c]["width"] = maxRowWidth;
        }
        return columns;
    }

    getTableWidth = () => {
        let sum = 0;
        let columns = this.getColumns();
        for (let x in columns) {
            sum += columns[x]["width"];
        }
        return sum;
    }

    onGridSort(sortColumn, sortDirection) {
        this.props.updateSort(sortColumn, sortDirection);
    }

    onSaleTypeChange(event) {
        var values = event.value;
        var types = [];
        for (var x in values) {
            types.push(values[x].value);
        }
        this.props.updateSaleFilter(types);
    }

    onHostessChange(event) {
        const values = event.value;
        var hostess = [];
        for (var x in values) {
            hostess.push(values[x].value);
        }
        this.props.updateHostessFilter(hostess);
    }

    onMonthChange(value) {
        const startDate = value.value.value[0]; // me code good
        const endDate = value.value.value[1];
        this.props.updateDateFilter(startDate, endDate);
    }

    calculateTotalSales() {
        let total = 0;
        let rows = this.props.rows;
        for (let r in rows) {
            if (rows.hasOwnProperty(r)) {
                total += Number(rows[r].commission.substr(1));
            }
        }
        return Formatters.moneyRounded(total);
    }

    rowGetter(i) {
        return this.props.rows[i];
    }

    public render() {
        return <PvReport
            dateFilter={this.props.dateFilter}
            hostesses={this.props.hostesses}
            hostessFilter={this.props.hostessFilter}
            onGridSort={this.onGridSort}
            onHostessChange={this.onHostessChange}
            onMonthChange={this.onMonthChange}
            onSaleTypeChange={this.onSaleTypeChange}
            rowGetter={this.rowGetter}
            rows={this.props.rows}
            typeFilter={this.props.typeFilter}
            loading={this.props.loading}
            totalSales={this.calculateTotalSales()}
            totalTransactions={this.props.rows.length}
            columns={this.getColumns()}
        />
    }
}

interface MappedProps {
    rows: Report.PvRow[],
    hostesses: any[],
    hostessFilter: string,
    typeFilter: string,
    dateFilter: {
        start: { month: number, year: number },
        end: { month: number, year: number }
    },
    loading: boolean
}

function mapStateToProps(state) {
    const { rows, saleTypeFilter, hostessFilter, sortColumn, sortDirection, startDate, endDate, loading } = state.pvReport;

    var filteredRows = typeFilterer(rows, saleTypeFilter);
    filteredRows = sortGrid(filteredRows, sortColumn, sortDirection);
    filteredRows = hostessFilterer(filteredRows, hostessFilter);
    filteredRows = dateFilterer(filteredRows, startDate, endDate);
    var hostesses = rows.map((row) => {
        return row.hostess;
    });
    hostesses = hostesses.filter((x, i, a) => a.indexOf(x) == i);

    hostesses = hostesses.map((hostess) => {
        return { value: hostess, label: hostess };
    });

    var currentHostessFilter = '';
    for (var x in hostessFilter)
        currentHostessFilter = currentHostessFilter.concat(hostessFilter[x]).concat(',');

    var currentTypeFilter = '';
    for (var x in saleTypeFilter)
        currentTypeFilter = currentTypeFilter.concat(saleTypeFilter[x]).concat(',');

    var currentDateFilter = {
        start: { month: startDate.getMonth(), year: startDate.getFullYear() },
        end: { month: endDate.getMonth(), year: endDate.getFullYear() }
    }

    return {
        rows: filteredRows,
        hostesses,
        hostessFilter: currentHostessFilter,
        typeFilter: currentTypeFilter,
        dateFilter: currentDateFilter,
        loading
    };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(PvReportContainer) as typeof PvReportContainer;