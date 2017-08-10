import * as ManageUserStore from './ManageUserStore';
import * as React from 'react';
import { ApplicationState } from '../../store'
import { connect } from 'react-redux';
import { ManageUsers } from './ManageUsers';
import { sortGrid } from '../../utils/DatatableFilters';

type ManageUserProps = MappedProps & typeof ManageUserStore.actionCreators;

class ManageUsersContainer extends React.Component<ManageUserProps, {}> {
    constructor(props) {
        super(props);

        if (this.props.loading) {
            this.props.getUsers();
        }
    }

    onGridSort(sortColumn, sortDirection) {
        this.props.updateSort(sortColumn, sortDirection);
    }

    render() {
        return (
            <ManageUsers
                users={this.props.rows}
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