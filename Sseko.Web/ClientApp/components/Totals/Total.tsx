import * as React from 'react';

interface TotalProps {
    titleIcon?: string;
    titleLabel: string;
    mainContent: any;
    secondaryContent?: any;
    decorator?: any;
}

const Total = (props: TotalProps) =>
    <div className="ibox float-e-margins total-container">
        <div className="ibox-title">
            <span className="label label-success pull-right">{props.titleIcon}</span>
            <h5>{props.titleLabel}</h5>
        </div>
        <div className="ibox-content">
            <h1 className="no-margins">{props.mainContent}</h1>
            <div className="stat-percent font-bold text-success">{props.decorator && <i className="fa fa-bolt"></i>} </div>
            <small>{props.secondaryContent}</small>
        </div>
    </div>;

export default Total;