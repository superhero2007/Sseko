import * as React from 'react';
import * as ReactDataGrid from 'react-data-grid';
import axios from 'axios'
import { EmptyRowsView } from '../components/EmptyRowsView';
import { Layout } from './shared/Layout'
import * as Cookies from 'universal-cookie';
import * as Report from '../store/DlReport'
import { connect } from 'react-redux';
import { ApplicationState } from '../store'
import { SelectList } from '../components/SelectList';
import * as _ from 'lodash';
import { levelFilter, sortGrid } from '../utils/DatatableFilters';

type DlReportProps = MappedProps & typeof Report.actionCreators;

interface MappedProps {
    rows: string[]
}

const columns = [
    { key: 'fellow', name: 'Fellow', width: 150, sortable: true },
    { key: 'parent', name: 'Parent', width: 100, sortable: true },
    { key: 'grandparent', name: 'Grandparent', width: 125, sortable: true },
    { key: 'level', name: 'Level', width: 100, sortable: true },
    { key: 'commissionableSales', name: 'Commissionable Sales', width: 200, sortable: true },
    { key: 'pv', name: 'Total Sales', width: 125, sortable: true }
];

const levelOptions = [
    { value: '1', label: '1' },
    { value: '2', label: '2' },
    { value: '3', label: '3' }
];

class DlReport extends React.Component<DlReportProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.rows.length == 0)
            this.props.getDlReport();

        this.onGridSort = this.onGridSort.bind(this);
        this.rowGetter = this.rowGetter.bind(this);
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

    rowGetter(i) {
        return this.props.rows[i];
    }

    public render() {
        return (
            <Layout>
                <SelectList
                    htmlId={"level-select"}
                    name={"levels"}
                    error={""}
                    label={"Levels"}
                    onChange={this.onLevelChange}
                    options={levelOptions}
                    multi
                />
                <ReactDataGrid
                    onGridSort={this.onGridSort}
                    columns={columns}
                    rowGetter={this.rowGetter}
                    rowsCount={this.props.rows.length}
                    emptyRowsView={EmptyRowsView}
                />
            </Layout>
        )
    }
}

function mapStateToProps(state) {
    const { rows, levels, sortColumn, sortDirection } = state.dlReport;
    var filteredItems = levelFilter(rows, levels);
    filteredItems = sortGrid(filteredItems, sortColumn, sortDirection);

    return { rows: filteredItems };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(DlReport) as typeof DlReport;
