import * as Utilities from './Utilities';
import { AxiosPromise } from 'axios';
import axios from 'axios';
import * as dtos from '../dtos';

export const Account = {
    Login(user: dtos.UserForAuthDto): AxiosPromise {
        return axios.post('/api/account/login/', user, { headers: Utilities.GetHeaders() })
    },

    SignUp(user: dtos.UserForSignUpDto): AxiosPromise {
        return axios.post('/api/account/signup/', user, {headers: Utilities.GetHeaders()})
    },

    SendPasswordResetLink(email: string): AxiosPromise {
        return axios.post('/api/account/SendResetPasswordLink/', email, { headers: Utilities.GetHeaders() })
    },

    VerifyResetLink(code: string): AxiosPromise {
        return axios.post('/api/account/VerifyResetLink/', code, { headers: Utilities.GetHeaders() })
    },

    ResetForgottenPassword(user: dtos.UserForPasswordResetDto): AxiosPromise {
        return axios.post('/api/account/ResetPassword/', user, { headers: Utilities.GetHeaders() })
    },

    UpdatePassword(user: dtos.UserForPasswordResetDto): AxiosPromise {
        return axios.post('/api/account/UpdatePassword/', user, { headers: Utilities.GetHeaders() })
    },

    ImpersonateUser(id: string): AxiosPromise {
        return axios.get('/api/account/Impersonate/' + id, { headers: Utilities.GetHeaders() })
    },

    AdminResetPassword(id: string): AxiosPromise {
        return axios.post('/api/account/adminresetpassword/', id, { headers: Utilities.GetHeaders() })
    }
}