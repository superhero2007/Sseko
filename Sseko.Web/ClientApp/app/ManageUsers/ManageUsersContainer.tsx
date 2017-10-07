import * as ManageUserStore from './ManageUserStore';
import * as React from 'react';
import { ApplicationState } from '../../store'
import { connect } from 'react-redux';
import { ManageUsers } from './ManageUsers';
import { sortGrid } from '../../utils/DatatableFilters';
import { RowButtonFormatter } from '../../components/DataTable/Formatters/RowButtonFormatter';
import { UserManagerButtonFormatter } from '../../components/DataTable/Formatters/UserManagerButtonFormatter';

type ManageUserProps = MappedProps & typeof ManageUserStore.actionCreators;

interface ManageUserState {
    columns: any;
}

function testFormatter(cell, row) {
    const props = {
        id: cell.id,
        disable: cell.disable,
        enable: cell.enable,
        resetPassword: cell.resetPassword,
        impersonate: cell.impersonate
    };
    return <UserManagerButtonFormatter value={props} />;
}

class ManageUsersContainer extends React.Component<ManageUserProps, ManageUserState> {
    constructor(props) {
        super(props);

        if (this.props.loading) {
            this.props.getUsers();
        }
        this.toggleEnable = this.toggleEnable.bind(this);
        this.onImpersonate = this.onImpersonate.bind(this);
        this.onResetPassword = this.onResetPassword.bind(this);
        this.state = {
            columns : [
                { key: 'username', name: 'Fellow', width: 250, sortable: 0 },
                { key: 'role', name: 'Role', width: 100, sortable: 0 },
                { key: 'actions', name: 'Actions', width: 500, sortable: -1, formatter: testFormatter }
            ]
        }
    }

    state = {
        columns: null
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
                columns={this.state.columns}
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