import * as React from 'react';
import { Label } from "./Label";

const moneyFormat = (amount) =>
    "$" + amount.toFixed(0).replace(/(\d)(?=(\d{3})+$)/g, "$1,");

const moneyFormatDecimal = (amount) =>
    "$" + amount.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,");

const Totals = ({ children }) =>
    <div>
        <div id="pv-totals">
            {children}
        </div>
    </div>;

const Total = ({ iconSrc, label, amount }) =>
    <div className="total-container">
        <img src={iconSrc} />
        <span className="total-label">
            {label}
            <br />
            <span title={amount} className="total-money">
                {amount}
            </span>
        </span>
    </div>;

export { Totals, Total };