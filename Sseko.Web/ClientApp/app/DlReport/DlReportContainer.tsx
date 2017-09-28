import * as React from 'react';
import * as Report from './DlReportStore'
import { ApplicationState } from '../../store'
import { connect } from 'react-redux';
import { DlReport } from './DlReport';
import { levelFilterer, sortGrid } from '../../utils/DatatableFilters';
import * as dtos from '../../dtos';

type DlReportProps = MappedProps & typeof Report.actionCreators;

class DlReportContainer extends React.Component<DlReportProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.rows.length == 0)
            this.props.getDlReport();

        this.onGridSort = this.onGridSort.bind(this);
        this.onLevelChange = this.onLevelChange.bind(this);
    }

    onGridSort(sortColumn, sortDirection) {
        this.props.updateSort(sortColumn, sortDirection);
    }

    onLevelChange(event) {
        var values = event.value;
        var levels = [];
        for (var x in values) {
            levels.push(values[x].value);
        }
        this.props.updateLevelFilter(levels);
    }

    onMonthChange(value) {
    }

    public render() {
        return <DlReport
            rows={this.props.rows}
            onLevelChange={this.onLevelChange}
            onGridSort={this.onGridSort}
            levelFilter={this.props.levelFilter}
            loading={this.props.loading}
            totalSales={"$0"}
            totalTransactions={0}
            totalPersonalVolume={"$2,466"}
            balance={"$749.82"}
            onMonthChange={this.onMonthChange}
        />
    }
}

interface MappedProps {
    rows: dtos.ReportForDownlineDto[],
    levelFilter: string,
    loading: boolean
}

function mapStateToProps(state) {
    const { rows, levelFilter, sortColumn, sortDirection, loading } = state.dlReport;
    var filteredItems = levelFilterer(rows, levelFilter);
    filteredItems = sortGrid(filteredItems, sortColumn, sortDirection);

    var levelFilterMapping = '';
    for (var x in levelFilter)
        levelFilterMapping = levelFilterMapping.concat(levelFilter[x]).concat(',');

    return { rows: filteredItems, levelFilter: levelFilterMapping, loading };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(DlReportContainer) as typeof DlReportContainer;
