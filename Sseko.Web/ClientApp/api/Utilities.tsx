import * as Cookies from 'universal-cookie';

export const GetHeaders = () => {
    var cookies = new Cookies();
    return { Authorization: "Bearer " + cookies.get("token") };
}