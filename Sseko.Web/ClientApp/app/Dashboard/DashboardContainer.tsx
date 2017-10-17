import * as React from 'react';
import * as Report from './DashboardStore';
import { ApplicationState } from '../../store';
import { connect } from 'react-redux';
import { Dashboard } from './Dashboard';
import { sortGrid, typeFilterer, hostessFilterer, dateFilterer } from '../../utils/DatatableFilters';
import { Formatters } from '../../utils/Formatters'
import * as dtos from '../../dtos';
import * as api from '../../api/';
import * as moment from 'moment';
type DashboardProps = MappedProps & typeof Report.actionCreators;


class DashboardContainer extends React.Component<DashboardProps, {}> {
    constructor(props) {
        super(props);
        this.props.getDashboardModel(this.props.dateFilter.startDate, this.props.dateFilter.endDate);

        this.onMonthChange = this.onMonthChange.bind(this);
        this.calculateTotalSales = this.calculateTotalSales.bind(this);
    }
    
    componentDidMount() {
        api.Reports.Dashboard(moment().subtract('1', 'year'), moment()).then(response => { });
    }

    onMonthChange(value1, value2) {
        const startDate = value1;
        const endDate = value2;

        this.props.updateDateFilter(startDate, endDate);
    }

    calculateTotalSales() {
        let total = 0;
        let rows = this.props.dashboardModel.myTransactions;
        for (let r in rows) {
            if (rows.hasOwnProperty(r)) {
                total += Number(rows[r].commissionalbeSale);
            }
        }
        return Formatters.moneyRounded(total);
    }

    calculateTotalPersonalVolume() {
        let total = 0;
        let rows = this.props.dashboardModel.myTransactions;
        for (let r in rows) {
            if (rows.hasOwnProperty(r)) {
                total += Number(rows[r].totalAmount);
            }
        }
        return Formatters.moneyRounded(total);
    }

    public render() {
        return <Dashboard
            dateFilter={this.props.dateFilter}
            onMonthChange={this.onMonthChange}
            rows={this.props.dashboardModel.myTransactions}
            loading={this.props.loading}
            totalSales={this.calculateTotalSales()}
            totalTransactions={( this.props.dashboardModel.myTransactions ? this.props.dashboardModel.myTransactions.length : 0 )}
            totalPersonalVolume={this.calculateTotalPersonalVolume()}
        />
    }
}

interface MappedProps {
    dashboardModel: any,
    dateFilter: {
        startDate: any,
        endDate: any
    },
    loading: boolean
}

function mapStateToProps(state) {
    const { dashboardModel, startDate, endDate, loading } = state.dashboard;
   
    var currentDateFilter = {
        startDate: startDate,
        endDate: endDate
    }

    return {
        dashboardModel,
        dateFilter: currentDateFilter,
        loading
    };
}

export default connect(
    (state: ApplicationState) => mapStateToProps(state),
    Report.actionCreators
)(DashboardContainer) as typeof DashboardContainer;