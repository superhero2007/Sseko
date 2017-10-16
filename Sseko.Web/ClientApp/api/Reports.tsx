import * as Utilities from './Utilities';
import { AxiosPromise } from 'axios';
import axios from 'axios';
import * as moment from 'moment';

export const Reports = {
    PersonalVolume(): AxiosPromise {
        return axios.get('/api/reports/personalvolume/', { headers: Utilities.GetHeaders() });
    },

    Downline(startDate, endDate): AxiosPromise {
        return axios.get('/api/reports/downline/?startDate=' + startDate + '&endDate=' + endDate, { headers: Utilities.GetHeaders() });
    },

    Dashboard(startDate: moment.Moment, endDate: moment.Moment): AxiosPromise {
        return axios.get('/api/reports/dashboard/?startDate=' + startDate.format("YYYY-MM-DD") + '&endDate=' + endDate.format("YYYY-MM-DD"), { headers: Utilities.GetHeaders() });
    }
}