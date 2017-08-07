import * as React from 'react';
import * as ReactDataGrid from 'react-data-grid';
import axios from 'axios'
import { EmptyRowsView } from '../components/EmptyRowsView';
import { Layout } from './shared/Layout'
import * as Cookies from 'universal-cookie';

interface ReportState {
    rows: DlRow[];
    loading: boolean;
    columns: Column[];
}

export class DlReport extends React.Component<{}, ReportState> {
    constructor() {
        super();
        const columns = [
            { key: 'fellow', name: 'Fellow' },
            { key: 'parent', name: 'Parent' },
            { key: 'grandparent', name: 'Grandparent' },
            { key: 'level', name: 'Level' },
            { key: 'commissionableSales', name: 'Commissionable Sales' },
            { key: 'totalSales', name: 'Total Sales' }
        ];
        this.state = { rows: [], loading: true, columns: columns };
        this.rowGetter = this.rowGetter.bind(this);
    }

    componentWillMount() {
        var cookies = new Cookies();
        axios.get('/api/Reports/Downline', { headers: { Authorization: "Bearer " + cookies.get("token") } })
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
                    emptyRowsView={EmptyRowsView}
                />
            </Layout>
        )
    }
}

interface DlRow {
    name: string,
    parent: string,
    grandparent: string,
    level: string,
    commissionableSales: string,
    totalSales: string,
}

interface Column {
    key: string,
    name: string
}