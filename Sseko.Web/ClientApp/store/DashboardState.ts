import * as dtos from '../dtos';
import * as moment from 'moment';
import { extendMoment } from 'moment-range';
const Moment = extendMoment(moment);

export default class DashboardState {
    dashboardModel: any;
    startDate: moment.Moment;
    endDate: moment.Moment;
    errors: string;
    loading: boolean;
}