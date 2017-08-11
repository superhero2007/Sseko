import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';

export const GetRole = () => {
    var cookies = new Cookies();
    var token = cookies.get('token');
    var decodedToken = Decoder(token);

    return decodedToken.role;
}

export const GetUsername = () => {
    var cookies = new Cookies();
    var token = cookies.get('token');
    var decodedToken = Decoder(token);

    return decodedToken.unique_name;
}

export const Logout = () => {
    RemoveCookie();
    window.location.href = '/Login';
}

export const LogoutWithoutRedirect = () => {
    RemoveCookie();
}

const RemoveCookie = () => {
    var cookies = new Cookies();
    cookies.remove('token');
}