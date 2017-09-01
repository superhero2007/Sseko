import * as React from 'react';
import { Label } from './Label';

const moneyFormat = (amount) =>
    "$" + amount.toFixed(0).replace(/(\d)(?=(\d{3})+$)/g, "$1,");

const moneyFormatDecimal = (amount) =>
    "$" + amount.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,");

const Totals = ({ children }) =>
    <div>
        <Label label="Filtered totals" />
        <div className="totals">
            {children}
        </div>
    </div>;

const Total = ({ iconSrc, label, amount, money = true }) =>
    <div className="totals-container">
        <img src={iconSrc} />
        <span className="totals-label">
            {label}
            <br />
            <span title={money ? moneyFormatDecimal(amount) : null} className="totals-money">
                {money ? moneyFormat(amount) : amount}
            </span>
        </span>
    </div>;

export { Totals, Total };