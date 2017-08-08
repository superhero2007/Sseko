import * as React from 'react';
import * as ReactDataGrid from 'react-data-grid';
import axios from 'axios'
import { Layout } from './shared/Layout'
import { EmptyRowsView } from '../components/EmptyRowsView';
import * as Cookies from 'universal-cookie';
import * as Report from '../store/PvReport'
import { connect } from 'react-redux';
import { ApplicationState } from '../store';
import { sortGrid } from '../utils/DatatableFilters';

type PvReportProps = MappedProps & typeof Report.actionCreators;

interface MappedProps {
    rows: string[]
}

const columns = [
    { key: 'date', name: 'Date', width: 100, sortable: true },
    { key: 'orderNumber', name: 'Order No', width: 100, sortable: true },
    { key: 'customer', name: 'Customer', width: 200, sortable: true },
    { key: 'hostess', name: 'Hostess', width: 200, sortable: true },
    { key: 'type', name: 'Type', width: 200, sortable: true },
    { key: 'commission', name: 'Commission', width: 125, sortable: true },
    { key: 'sale', name: 'Total', width: 100, sortable: true }
];

class PvReport extends React.Component<PvReportProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.rows.length == 0)
            this.props.getPvReport();

        this.onGridSort = this.onGridSort.bind(this);
        this.rowGetter = this.rowGetter.bind(this);
    }

    onGridSort(sortColumn, sortDirection) {
        this.props.updateSort(sortColumn, sortDirection);
    }

    rowGetter(i) {
        return this.props.rows[i];
    }

    public render() {
        return (
            <Layout>
                <ReactDataGrid
                    onGridSort={this.onGridSort}
                    columns={columns}
                    rowGetter={this.rowGetter}
                    rowsCount={this.props.rows.length}
                    minHeight={500}
                    emptyRowsView={EmptyRowsView}
                />
            </Layout>
        )
    }
}
function mapStateToProps(state) {
    const { rows, levels, sortColumn, sortDirection } = state.pvReport;

    var filteredRows = sortGrid(rows, sortColumn, sortDirection);

    return { rows: filteredRows };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(PvReport) as typeof PvReport;