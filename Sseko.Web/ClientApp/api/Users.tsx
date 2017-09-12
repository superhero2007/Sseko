import * as Utilities from './Utilities';
import { AxiosPromise } from 'axios';
import axios from 'axios';
import * as dtos from '../dtos';

export const Users = {
    Get(): AxiosPromise {
        return axios.get('/api/users/', { headers: Utilities.GetHeaders() });
    },
    ToggleEnabled(id: string): AxiosPromise {
        return axios.get('/api/users/toggleenabled/' + id, { headers: Utilities.GetHeaders() });
    }
}