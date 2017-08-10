import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'

interface ManageUserProps {
    users: any[],
    loading: boolean,
    onGridSort: (column: string, dir: string) => any
}

export const ManageUsers = (props: ManageUserProps) => {
    return (
        <Layout>
            <DataTable
                columns={columns}
                rows={props.users}
                onGridSort={props.onGridSort}
                isLoading={props.loading}
            />
        </Layout>
    );
}

const columns = [
    { key: 'username', name: 'Fellow', width: 250, sortable: true },
    { key: 'role', name: 'Role', width: 100, sortable: true }
];