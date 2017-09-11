import * as React from 'react';
import Progress from '../Progress';
import Navigation from '../SideNav/Navigation';
import Footer from '../Footer';
import TopHeader from '../TopHeader';
import { correctHeight, detectBody } from '../Helpers';
declare let $: any;

export class Layout extends React.Component<{}, {}> {
    componentDidMount() {
        // Run correctHeight function on load and resize window event
        $(window).bind("load resize", function() {
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
                <Navigation />
                <div id="page-wrapper" className="gray-bg">
                    <TopHeader />
                        {this.props.children}
                    <Footer />
                </div>
            </div>
        )
    }
}