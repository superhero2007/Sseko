import './Banner.css';
import * as React from 'react';
import * as ReactDOM from "react-dom";
import { Layout } from '../../components/Layout/Layout'
import { Totals, Total } from '../../components/HelperTotals';
const personIcon = require<string>('../../img/personal-volume.png');
const salesIcon = require<string>('../../img/commissionable-sales.png');
const transactionsIcon = require<string>('../../img/transaction.png');

interface BannerProps {
    dateFilter: { startDate: any, endDate: any };
    hasHostesses: boolean;
    hostesses: string[];
    hostessFilter: string;
    onGridSort: (sortColumn: string, sortDir: string) => any;
    onHostessChange: (event: any) => any;
    onMonthChange: (value1: any, value2: any) => any;
    onSaleTypeChange: (event: any) => any;
    rowGetter: (i: number) => any;
    rows: any;
    typeFilter: string;
    loading: boolean;
    totalSales: string;
    totalTransactions: number;
    totalPersonalVolume: string;
    columns: any;
}

export class Banner extends React.Component<BannerProps, {}> {
    
    public render() {
        return <Layout>
            <div className="Banneroption">
                <div className="BanneroptionHeader">
                    <h3>Create Your Own Personal Link</h3>
                </div>
                <div className="BanneroptionBody">
                    <div className="subBody">
                        <span>Please fill in one of the links from our store such as: <strong>product URL, category URL</strong> or <strong>other pages' URL</strong> into the text box below:</span>
                    </div>
                    <div className="subBody">
                        <input type="text" placeholder="Enter URL" />
                        <button>OK</button>
                    </div>
                    <div className="subBody">
                        <span>Receive a unique affiliate link:</span>
                    </div>
                    <div className="subBody">
                        <span className="light">http://qa.ssekodesigns.com?acc=eccbc87e4b5ce2fe28308fd9f2a7baf3</span>
                    </div>
                </div>
            </div>
            <div className="Banneroption">
                <div className="BanneroptionHeader">
                    <h3>Shorten URL</h3>
                </div>
                <div className="BanneroptionBody">
                    <div className="subBody">
                        <span>Please enter your URL to shorten:</span>
                    </div>
                    <div className="subBody">
                        <input type="text" placeholder="Enter URL" />
                        <button>GO</button>
                    </div>
                </div>
            </div>
        </Layout>
    }
}


