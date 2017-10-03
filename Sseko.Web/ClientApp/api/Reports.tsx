import * as Utilities from './Utilities';
import { AxiosPromise } from 'axios';
import axios from 'axios';

export const Reports = {
    PersonalVolume(): AxiosPromise {
        return axios.get('/api/reports/personalvolume/', { headers: Utilities.GetHeaders() });
    },

    Downline(startDate, endDate): AxiosPromise {
        return axios.get('/api/reports/downline/?startDate=' + startDate + '&endDate=' + endDate, { headers: Utilities.GetHeaders() });
    }
}