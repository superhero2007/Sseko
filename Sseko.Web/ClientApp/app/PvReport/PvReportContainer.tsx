import * as React from 'react';
import * as Report from './PvReportStore'
import { ApplicationState } from '../../store';
import { connect } from 'react-redux';
import { PvReport } from './PvReport';
import { sortGrid, typeFilterer, hostessFilterer, dateFilterer } from '../../utils/DatatableFilters';

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
        var values = event.value;
        var hostess = [];
        for (var x in values) {
            hostess.push(values[x].value);
        }
        this.props.updateHostessFilter(hostess);
    }

    onMonthChange(value) {
        var start = value.from;
        var end = value.to
        var startDate = new Date(start.year, start.month - 1);
        var endDate = new Date(end.year, end.month, 0);
        this.props.updateDateFilter(startDate, endDate);
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
        />
    }
}

interface MappedProps {
    rows: string[],
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