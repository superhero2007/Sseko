import * as React from 'react';
import Progress from '../Progress';
import Navigation from '../Navigation';
import Footer from '../Footer';
import TopHeader from '../TopHeader';
import { correctHeight, detectBody } from '../Helpers';

export class Layout extends React.Component<{}, {}> {
    render() {
        return (
            <div id="wrapper">
                <Progress />
                <Navigation />
                <div id="page-wrapper" className="gray-bg">
                    <TopHeader />
                        {this.props.children}
                    <Footer />
                </div>
            </div>
        )
}

    componentDidMount() {

        // Run correctHeight function on load and resize window event
        $(window).bind("load resize", function() {
            correctHeight();
            detectBody();
        });

        // Correct height of wrapper after metisMenu animation.
        $('.metismenu a').click(() => {
            setTimeout(() => {
                correctHeight();
            }, 300)
        });
    }
}