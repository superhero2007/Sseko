import '../css/month-picker.css'
import * as React from 'react';
import Picker from 'react-month-picker';
import { MonthBox } from './MonthBox';

interface MonthPickerProps {
    onChange: (event: any) => any;
    start: { year: number, month: number },
    end: { year: number, month: number }
}

interface MonthPickerState {
    mrange: any,
    value: any
}

export class MonthPicker extends React.Component<MonthPickerProps, MonthPickerState> {
    constructor(props) {
        super(props)

        this.state = {
            mrange: {
                from: this.props.start,
                to: this.props.end
            },
            value: 'N/A'
        }

        this._handleClickRangeBox = this._handleClickRangeBox.bind(this)
        this.handleRangeChange = this.handleRangeChange.bind(this)
        this.handleRangeDissmis = this.handleRangeDissmis.bind(this)
    }

    componentWillReceiveProps(nextProps) {
        this.setState({
            value: nextProps.value || 'N/A'
        })
    }

    render() {

        let pickerLang = {
            months: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
            from: 'From',
            to: 'To'
        }
        let mrange = this.state.mrange;

        let makeText = m => {
            if (m && m.year && m.month) return (pickerLang.months[m.month - 1] + '. ' + m.year)
            return '?'
        }

        return (
            <div>
                <label>Date</label>
                <div className="edit">
                    <Picker
                        ref="pickRange"
                        years={{ min: 2013 }} 
                        range={mrange}
                        lang={pickerLang}
                        theme="light"
                        onChange={this.props.onChange}
                        onDismiss={this.handleRangeDissmis}
                    >
                        <MonthBox value={makeText(mrange.from) + ' ~ ' + makeText(mrange.to)} onClick={this._handleClickRangeBox} />
                    </Picker>
                </div>
            </div>
        )
    }

    _handleClickRangeBox(e) {
        this.refs.pickRange.show()
    }
    handleRangeChange(value, text, listIndex) {
        //
    }
    handleRangeDissmis(value) {
        this.setState({ mrange: value })
    }
}