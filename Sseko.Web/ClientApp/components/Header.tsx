import * as React from 'react';

export class Header extends React.PureComponent<{}, {}> {
    render() {
        const today = new Date();
        const days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
        const months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

        return (
            <div className="header">
                <span>
                    Welcome <strong>Genavieve Moyer</strong>. Today is  {days[today.getDay()]}, <strong>{months[today.getMonth()]} {today.getDate()}, {today.getFullYear()}</strong>
                </span>
            </div>
        )
    }
}
