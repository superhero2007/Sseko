import * as React from 'react';
import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';

export const Authorization = (allowedRoles) =>
    (WrappedComponent) =>
        class Authorization extends React.Component<{}, {}> {
            render() {
                var cookies = new Cookies();
                var token = cookies.get('token');

                if (token == null)
                    window.location.href = '/Login';

                var decodedToken = Decoder(token);
                const role = decodedToken.role;
                if (allowedRoles.includes(role)) {
                    return <WrappedComponent {...this.props} />
                } else {
                    window.location.href = '/404';
                };
            }
        }