import * as React from 'react';	

interface MonthBoxProps {
    value: string,
    onClick: (event: any) => any
}

interface MonthBoxState {
    value: string
}

export class MonthBox extends React.Component<MonthBoxProps, MonthBoxState> {
    constructor(props, context) {
        super(props, context)

        this.state = {
            value: this.props.value || 'N/A'
        }

        this._handleClick = this._handleClick.bind(this)
    }

    componentWillReceiveProps(nextProps) {
        this.setState({
            value: nextProps.value || 'N/A'
        })
    }

    render() {
        return (
            <a 
                type="button"
                ariaRole="button"
                href="#"
                className="btn btn-secondary"
                onClick={this._handleClick}
            >
                {this.state.value}
            </a>
        )
    }

    _handleClick(e) {
        this.props.onClick && this.props.onClick(e)
    }
}