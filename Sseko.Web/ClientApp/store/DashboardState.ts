import * as dtos from '../dtos';
import * as moment from 'moment';

export default class DashboardState {
    dashboardModel: any;
    rows: dtos.ReportForPersonalVolumeDto[];
    saleTypeFilter: string[];
    hostessFilter: string[];
    sortColumn: string;
    sortDirection: string;
    startDate: moment.Moment;
    endDate: moment.Moment;
    errors: string;
    loading: boolean;
}