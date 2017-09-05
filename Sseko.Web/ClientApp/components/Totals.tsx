import * as React from 'react';
import { Label } from './Label';

const moneyFormat = (amount) =>
    "$" + amount.toFixed(0).replace(/(\d)(?=(\d{3})+$)/g, "$1,");

const moneyFormatDecimal = (amount) =>
    "$" + amount.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,");

const Totals = ({ children }) =>
    <div id="totals">
        {children}
    </div>;

const Total = ({ iconSrc, label, amount, money = true }) =>
    <div className="total-container">
        <img src={iconSrc} />
        <span className="total-label">
            {label}
            <br />
            <span title={money ? moneyFormatDecimal(amount) : null} className="total-money">
                {money ? moneyFormat(amount) : amount}
            </span>
        </span>
    </div>;

export { Totals, Total };