﻿import * as React from 'react';
//import pace from '../../../public/vendor/pace/pace';
import '../vendor/pace/pace.js';

class Progress extends React.Component<{}, {}> {
    componentDidMount() {
        const pace = (window as any).pace;
        window.Pace.start();
    }

    render() {
        return (null)
    }
}

export default Progress
