import * as ManageUserStore from './ManageUserStore';
import * as React from 'react';
import { ApplicationState } from '../../store'
import { connect } from 'react-redux';
import { ManageUsers } from './ManageUsers';
import { sortGrid } from '../../utils/DatatableFilters';
import { RowButtonFormatter } from '../../components/DataTable/Formatters/RowButtonFormatter';

type ManageUserProps = MappedProps & typeof ManageUserStore.actionCreators;

class ManageUsersContainer extends React.Component<ManageUserProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.loading) {
            this.props.getUsers();
        }
        this.toggleEnable = this.toggleEnable.bind(this);
        this.onImpersonate = this.onImpersonate.bind(this);
        this.onResetPassword = this.onResetPassword.bind(this);
    }

    onGridSort(sortColumn, sortDirection) {
        this.props.updateSort(sortColumn, sortDirection);
    }

    formatRows() {
        return RowButtonFormatter(this.props.rows,
            {
                impersonate: this.onImpersonate,
                toggleEnable: this.toggleEnable,
                resetPassword: this.onResetPassword
            });
    }

    onImpersonate(id) {
        return () => this.props.impersonate(id);
    }

    toggleEnable(id) {
        return () => this.props.toggleEnable(id);
    }

    onResetPassword(id) {
        return () => this.props.resetPassword(id);
    }

    render() {
        return (
            <ManageUsers
                users={this.formatRows()}
                onGridSort={this.onGridSort}
                loading={this.props.loading}
            />
        );
    }
}

interface MappedProps {
    rows: string[],
    loading: boolean
}

function mapStateToProps(state) {
    const { rows, loading, sortColumn, sortDirection } = state.users;

    var filteredRows = [];
    filteredRows = sortGrid(rows, sortColumn, sortDirection);

    return { rows: filteredRows, loading };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    ManageUserStore.actionCreators
)(ManageUsersContainer) as typeof ManageUsersContainer;