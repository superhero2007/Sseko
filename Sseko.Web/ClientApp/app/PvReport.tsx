import * as React from 'react';
import * as ReactDataGrid from 'react-data-grid';
import axios from 'axios'
import { Layout } from './shared/Layout'
import { EmptyRowsView } from '../components/EmptyRowsView';
import * as Cookies from 'universal-cookie';

interface ReportState {
    rows: PvRow[];
    loading: boolean;
    columns: Column[];
}

export class PvReport extends React.Component<{}, ReportState> {
    constructor() {
        super();
        const columns = [
            { key: 'createdTime', name: 'Date' },
            { key: 'orderId', name: 'Order No' },
            { key: 'customerEmail', name: 'Customer' },
            { key: 'hostess', name: 'Hostess' },
            { key: 'type', name: 'Type' },
            { key: 'commission', name: 'Commission' },
            { key: 'totalAmount', name: 'Total' }
        ];
        this.state = { rows: [], loading: true, columns: columns };

        this.rowGetter = this.rowGetter.bind(this);
    }

    componentWillMount() {
        var cookies = new Cookies();
        axios.get('/api/reports/PersonalVolume', { headers: { Authorization: "Bearer " + cookies.get("token") } })
            .then(response => {
                this.setState({ rows: response.data, loading: false });
            });
    }

    rowGetter(i) {
        return this.state.rows[i];
    }

    public render() {
        return (
            <Layout>
                <ReactDataGrid
                    columns={this.state.columns}
                    rowGetter={this.rowGetter}
                    rowsCount={this.state.rows.length}
                    minHeight={500}
                    emptyRowsView={EmptyRowsView}
                />
            </Layout>
        )
    }
}

interface PvRow {
    createdTime: string,
    orderId: string,
    customerEmail: string,
    hostess: string,
    type: string,
    commision: string,
    totalAmount: string,
}

interface Column {
    key: string,
    name: string
}