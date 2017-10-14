import * as React from 'react';
import { DataTable } from '../../components/DataTable/DataTable';
import { Layout } from '../../components/Layout/Layout'

interface ManageUserProps {
    users: any[],
    loading: boolean,
    onGridSort: (column: string, dir: string) => any,
    columns: any
}

interface ManageUserState {
    buttonFilter: number;
}

export class ManageUsers extends React.Component<ManageUserProps, ManageUserState> {
    constructor(props) {
        super(props);
        
        this.state = {
            buttonFilter: 0
        }
        this.buttonFilterer = this.buttonFilterer.bind(this);
    }

    state = {
        buttonFilter: 0
    }

    buttonFilterer(value, event) {
        console.log(value);
        this.setState({ buttonFilter: value });
    }

    render() {
        let realusers = [];
        let count = this.props.users.length;
        let count1 = 0, count2 = 0;
        for (let i = 0; i < this.props.users.length; i++)
            if (this.props.users[i].enabled)
                realusers.push(this.props.users[i]);
        count1 = realusers.length;
        count2 = count - count1;
        if (this.state.buttonFilter == 2) {
            realusers = [];
            for (let i = 0; i < this.props.users.length; i++)
                if (!this.props.users[i].enabled)
                    realusers.push(this.props.users[i]);
        }
        else if (this.state.buttonFilter == 0) {
            realusers = this.props.users;
        }
        return (
            <Layout>
                <div className="filterButton">
                    <button onClick={(e) => this.buttonFilterer(0, e)}>All ({count})</button>
                    <button onClick={(e) => this.buttonFilterer(1, e)}>Active ({count1})</button>
                    <button onClick={(e) => this.buttonFilterer(2, e)}>Inactive ({count2})</button>
                </div>
                <DataTable
                    columns={this.props.columns}
                    rows={realusers}
                    onGridSort={this.props.onGridSort}
                    isLoading={this.props.loading}
                />
            </Layout>
        );
    }
}

