import * as React from 'react';
import * as Report from './DashboardStore';
import { ApplicationState } from '../../store';
import { connect } from 'react-redux';
import { Dashboard } from './Dashboard';
import { sortGrid, typeFilterer, hostessFilterer, dateFilterer } from '../../utils/DatatableFilters';
import { Formatters } from '../../utils/Formatters'
import * as dtos from '../../dtos';
import * as api from '../../api/';
import * as moment from 'moment';
type DashboardProps = MappedProps & typeof Report.actionCreators;

interface DashboardState {
    columns: any;
}

class DashboardContainer extends React.Component<DashboardProps, DashboardState> {
    constructor(props) {
        super(props);

        if (this.props.rows.length == 0)
            this.props.getDashboardModel(this.props.dateFilter.startDate, this.props.dateFilter.endDate);

        this.onGridSort = this.onGridSort.bind(this);
        this.rowGetter = this.rowGetter.bind(this);
        this.onSaleTypeChange = this.onSaleTypeChange.bind(this);
        this.onHostessChange = this.onHostessChange.bind(this);
        this.onMonthChange = this.onMonthChange.bind(this);
        this.calculateTotalSales = this.calculateTotalSales.bind(this);
        this.state = {
            columns: [
                { key: 'date', name: 'DATE', sortable: 0 },
                { key: 'orderNumber', name: 'ORDER #', sortable: 0 },
                { key: 'customer', name: 'CUSTOMER', sortable: 0 },
                { key: 'hostess', name: 'HOSTESS', sortable: -1 },
                { key: 'type', name: 'TRANSACTION TYPE', sortable: -1 },
                { key: 'commission', name: 'COMMISSIONABLE SALE', sortable: 0 },
                { key: 'return', name: 'RETURNS', sortable: 0 },
                { key: 'sale', name: 'TOTAL SALE', sortable: 0 }
            ]
        };
    }

    state = {
        columns: []
    }

    componentDidMount() {
        api.Reports.Dashboard(moment().subtract('364', 'days'), moment()).then(response => { });
    }

    getHasHostesses = () => {
        for (let i in this.props.hostesses) {
            if (this.props.hostesses[i].label) {
                return true;
            }
        }
        return false;
    }

    getColumns = () => {
        let columns = this.state.columns;
        // Calculate column widths based on character counts
        for (let c in columns) {
            // Magic numbers
            let headerCharacterWidth = 13;
            let rowItemCharacterWidth = 8;
            let headerPadding = 15;
            let rowPadding = 15;
            let sortable = 18;
            //

            let headerWidth = columns[c]["name"].length * headerCharacterWidth + headerPadding + (columns[c]["sortable"]>=0 ? sortable : 0);

            // Find the widest row item
            let maxRowWidth = headerWidth;
            this.props.rows.map(row => {
                maxRowWidth = Math.max(maxRowWidth, row[columns[c].key] ? row[columns[c].key].length * rowItemCharacterWidth + rowPadding : 0);
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
        if (sortDirection >= 0) {
            var stateCopy = Object.assign({}, this.state);
            for (let index in stateCopy.columns) {
                if (stateCopy.columns[index].key == sortColumn)
                    stateCopy.columns[index].sortable = (sortDirection + 1) % 3;
                else if (stateCopy.columns[index].sortable > 0)
                    stateCopy.columns[index].sortable = 0;
            }

            this.setState(stateCopy);
            if (sortDirection == 0)
                this.props.updateSort(sortColumn, 'ASC');
            else if (sortDirection == 1)
                this.props.updateSort(sortColumn, 'DESC');
            else
                this.props.updateSort(sortColumn, 'NONE');
        }
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
        /*for (var x in values) {
            hostess.push(values[x].value);
        }*/
        if (values != "AllValue") {
            hostess.push(values);
        }
        this.props.updateHostessFilter(hostess);
    }

    onMonthChange(value1, value2) {
        const startDate = value1; // my code good
        const endDate = value2;

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

    calculateTotalPersonalVolume() {
        let total = 0;
        let rows = this.props.rows;
        for (let r in rows) {
            if (rows.hasOwnProperty(r)) {
                total += Number(rows[r].sale.substr(1));
            }
        }
        return Formatters.moneyRounded(total);
    }

    rowGetter(i) {
        return this.props.rows[i];
    }

    public render() {
        return <Dashboard
            dateFilter={this.props.dateFilter}
            hasHostesses={this.getHasHostesses()}
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
            totalPersonalVolume={this.calculateTotalPersonalVolume()}
            columns={this.getColumns()}
        />
    }
}

interface MappedProps {
    rows: dtos.ReportForPersonalVolumeDto[],
    hostesses: any[],
    hostessFilter: string,
    typeFilter: string,
    dateFilter: {
        startDate: any,
        endDate: any
    },
    loading: boolean
}

function mapStateToProps(state) {
    const { rows, saleTypeFilter, hostessFilter, sortColumn, sortDirection, startDate, endDate, loading } = state.pvReport;

    var filteredRows = typeFilterer(rows, saleTypeFilter);
    filteredRows = sortGrid(filteredRows, sortColumn, sortDirection);
    filteredRows = hostessFilterer(filteredRows, hostessFilter);
    filteredRows = dateFilterer(filteredRows, startDate, endDate);
    for (var x in filteredRows)
        filteredRows[x].return = Formatters.moneyDecimal( Number(filteredRows[x].sale.substr(1)) - Number(filteredRows[x].commission.substr(1)) );
    var hostesses = rows.map((row) => {
        return row.hostess;
    });
    hostesses = hostesses.filter((x, i, a) => a.indexOf(x) == i);

    hostesses = hostesses.map((hostess) => {
        let label = hostess;
        if (hostess == "")
            label = "Other"
        return { value: hostess, label: label };
    });

    hostesses.unshift({
        value: "AllValue",
        label: "All"
    });

    var currentHostessFilter = '';
    for (var x in hostessFilter)
        currentHostessFilter = currentHostessFilter.concat(hostessFilter[x]).concat(',');

    var currentTypeFilter = '';
    for (var x in saleTypeFilter)
        currentTypeFilter = currentTypeFilter.concat(saleTypeFilter[x]).concat(',');

    var currentDateFilter = {
        startDate: startDate,
        endDate: endDate
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
)(DashboardContainer) as typeof DashboardContainer;