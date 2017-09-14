import * as React from 'react';
import Progress from '../Progress';
import Navigation from '../SideNav/Navigation';
import Footer from '../Footer';
import TopHeader from '../TopHeader/TopHeader';
import { correctHeight, detectBody } from '../Helpers';
import { GetRole } from '../../utils/AuthService';
declare let $: any;

export class Layout extends React.Component<{}, {}> {
    componentDidMount() {
        // Run correctHeight function on load and resize window event
        $(window).bind("load resize", () => {
            correctHeight();
            detectBody();
        });

        // Correct height of wrapper after metisMenu animation
        $('.metismenu a').click(() => {
            setTimeout(() => {
                correctHeight();
            }, 300)
        });
    }

    render() {
        return (
            <div id="wrapper">
                <Navigation role={GetRole()} />
                <div id="page-wrapper">
                    <TopHeader role={GetRole()} />
                    <div className="wrapper wrapper-content">
                        {this.props.children}
                    </div>
                    <Footer />
                </div>
            </div>
        )
    }
}