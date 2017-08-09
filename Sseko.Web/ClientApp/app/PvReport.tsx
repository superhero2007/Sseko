import axios from 'axios'
import { sortGrid, typeFilterer, hostessFilterer } from '../utils/DatatableFilters';
import { SelectList } from '../components/SelectList';
import { MonthPicker } from '../components/MonthPicker';
import { Layout } from './shared/Layout'
import { EmptyRowsView } from '../components/EmptyRowsView';
import { connect } from 'react-redux';
import { ApplicationState } from '../store';
import * as Report from '../store/PvReport'
import * as ReactDataGrid from 'react-data-grid';
import * as React from 'react';
import * as Cookies from 'universal-cookie';

type PvReportProps = MappedProps & typeof Report.actionCreators;

interface MappedProps {
    rows: string[],
    hostesses: any[],
    hostessFilter: string,
    typeFilter: string
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

const saleTypeOptions = [
    { value: 'Personal Purchase', label: 'Personal Purchase' },
    { value: 'Hostess Program', label: 'Hostess Program' },
    { value: 'Affiliate Sale', label: 'Affiliate Sale' },
    { value: 'Other', label: 'Other' }
]

class PvReport extends React.Component<PvReportProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.rows.length == 0)
            this.props.getPvReport();

        this.onGridSort = this.onGridSort.bind(this);
        this.rowGetter = this.rowGetter.bind(this);
        this.onSaleTypeChange = this.onSaleTypeChange.bind(this);
        this.onHostessChange = this.onHostessChange.bind(this);
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

    onMonthChange(event) {

    }

    rowGetter(i) {
        return this.props.rows[i];
    }

    public render() {

        return (
            <Layout>
                <MonthPicker
                    onChange={this.onMonthChange}
                    start={{ year: 2014, month: 8 }}
                    end={{ year: 2016, month: 8 }}
                />
                <SelectList
                    htmlId={"hostess-select"}
                    name={"hostesses"}
                    error={""}
                    label={"Hostess"}
                    onChange={this.onHostessChange}
                    options={this.props.hostesses}
                    initialValue={this.props.hostessFilter}
                    multi
                />
                <SelectList
                    htmlId={"program-select"}
                    name={"programs"}
                    error={""}
                    label={"Sale Type"}
                    onChange={this.onSaleTypeChange}
                    options={saleTypeOptions}
                    initialValue={this.props.typeFilter}
                    multi
                />
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
    const { rows, saleTypeFilter, hostessFilter, sortColumn, sortDirection } = state.pvReport;

    var filteredRows = typeFilterer(rows, saleTypeFilter);
    filteredRows = sortGrid(filteredRows, sortColumn, sortDirection);
    filteredRows = hostessFilterer(filteredRows, hostessFilter)

    var hostesses = rows.map((row) => {
        return row.hostess;
    });
    hostesses = hostesses.filter((x, i, a) => a.indexOf(x) == i);

    hostesses = hostesses.map((hostess) => {
        return { value: hostess, label: hostess };
    });

    var hostessFilterMapping = '';
    for (var x in hostessFilter)
        hostessFilterMapping = hostessFilterMapping.concat(hostessFilter[x]).concat(',');

    var typeFilterMapping = '';
    for (var x in saleTypeFilter)
        typeFilterMapping = typeFilterMapping.concat(saleTypeFilter[x]).concat(',');
    return { rows: filteredRows, hostesses, hostessFilter: hostessFilterMapping, typeFilter: typeFilterMapping };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(PvReport) as typeof PvReport;