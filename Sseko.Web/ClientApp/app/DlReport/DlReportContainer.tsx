import * as React from 'react';
import * as Report from './DlReportStore'
import { ApplicationState } from '../../store'
import { connect } from 'react-redux';
import { DlReport } from './DlReport';
import { levelFilterer, sortGrid } from '../../utils/DatatableFilters';
import * as dtos from '../../dtos';
import { Formatters } from '../../utils/Formatters'

type DlReportProps = MappedProps & typeof Report.actionCreators;

interface DlReportState {
    columns: any;
}

class DlReportContainer extends React.Component<DlReportProps, DlReportState> {
    constructor(props) {
        super(props);
        if (this.props.rows.length == 0)
            this.props.getDlReport(props.startDate, props.endDate);

        this.onGridSort = this.onGridSort.bind(this);
        this.onLevelChange = this.onLevelChange.bind(this);
        this.onMonthChange = this.onMonthChange.bind(this);
        this.onHostessChange = this.onHostessChange.bind(this);

        this.state = {
            columns : [
                { key: 'fellow', name: 'NAME', width: 150, sortable: -1 },
                { key: 'parent', name: 'UPLINE', width: 100, sortable: -1 },
                { key: 'grandparent', name: 'UPLINE 2', width: 125, sortable: -1 },
                { key: 'level', name: 'LEVEL', width: 100, sortable: 0 },
                { key: 'commissionableSales', name: 'TOTAL CS', width: 125, sortable: 0 },
                { key: 'pv', name: 'TOTAL PV', width: 125, sortable: -1 }
            ]
        };
    }

    state = {
        columns: []
    }

    onGridSort(sortColumn, sortDirection) {
        if (sortDirection >= 0) {
            var stateCopy = Object.assign({}, this.state);
            for (let index in stateCopy.columns) {
                if (stateCopy.columns[index].key == sortColumn)
                    stateCopy.columns[index].sortable = (sortDirection + 1) % 3;
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

    onLevelChange(event) {
        var values = event.value;
        var levels = [];
        for (var x in values) {
            levels.push(values[x].value);
        }
        this.props.updateLevelFilter(levels);
    }

    onMonthChange(value1, value2) {
        const startDate = value1; // my code good
        const endDate = value2;
        this.props.updateDateFilter(startDate, endDate);
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

    calculateTotalSales() {
        let total = 0;
        let rows = this.props.rows;
        for (let r in rows) {
            if (rows.hasOwnProperty(r)) {
                total += Number(rows[r].commissionableSales.substr(1));
            }
        }
        return Formatters.moneyRounded(total);
    }

    calculateTotalPersonalVolume() {
        let total = 0;
        let rows = this.props.rows;
        for (let r in rows) {
            if (rows.hasOwnProperty(r)) {
                total += Number(rows[r].pv.substr(1));
            }
        }
        return Formatters.moneyRounded(total);
    }


    public render() {
        return <DlReport
            columns={this.state.columns}
            rows={this.props.rows}
            onLevelChange={this.onLevelChange}
            onGridSort={this.onGridSort}
            levelFilter={this.props.levelFilter}
            loading={this.props.loading}
            totalSales={this.calculateTotalSales()}
            totalTransactions={this.props.rows.length}
            totalPersonalVolume={this.calculateTotalPersonalVolume()}
            onHostessChange={this.onHostessChange}
            onMonthChange={this.onMonthChange}
            startDate={this.props.startDate}
            endDate={this.props.endDate}
        />
    }
}

interface MappedProps {
    rows: dtos.ReportForDownlineDto[],
    levelFilter: string[],
    loading: boolean,
    startDate: any,
    endDate: any
}

function mapStateToProps(state) {
    const { rows, levelFilter, sortColumn, sortDirection, startDate, endDate, loading } = state.dlReport;
    var filteredItems = levelFilterer(rows, levelFilter);
    filteredItems = sortGrid(filteredItems, sortColumn, sortDirection);
    
    return { rows: filteredItems, levelFilter: levelFilter, startDate: startDate, endDate: endDate, loading };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(DlReportContainer) as typeof DlReportContainer;
