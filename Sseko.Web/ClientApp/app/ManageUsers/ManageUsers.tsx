import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'

interface ManageUserProps {
    users: any[],
    loading: boolean,
    onGridSort: (column: string, dir: string) => any,
    columns: any
}

export const ManageUsers = (props: ManageUserProps) => {
    return (
        <Layout>
            <DataTable
                columns={props.columns}
                rows={props.users}
                onGridSort={props.onGridSort}
                isLoading={props.loading}
            />
        </Layout>
    );
}

