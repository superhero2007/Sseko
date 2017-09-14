import * as React from 'react';

export default class TotalGroup extends React.Component<{}, {}>{
    render() {
        var colSize = Math.floor(12 / React.Children.count(this.props.children));
        let colChildren = [];
        React.Children.forEach(this.props.children, child => {
            colChildren.push(<div className={"col-lg-" + colSize}>
                {child}
            </div>);
        })
        return (
            <div id="pv-totals" className="row">
                {colChildren.map(child => {
                    return child;
                })}
            </div>
        )
    }
}