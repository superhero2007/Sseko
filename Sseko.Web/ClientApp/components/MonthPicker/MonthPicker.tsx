import * as React from 'react';
import './month-picker.css'
import { MonthBox } from './MonthBox';
import Picker from 'react-month-picker';
import { Label } from '../Label';

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
        var start = this.props.start;
        start.month += 1;
        var end = this.props.end;
        end.month += 1;
        this.state = {
            mrange: {
                from: start,
                to: end
            },
            value: 'N/A'
        }

        this._handleClickRangeBox = this._handleClickRangeBox.bind(this)
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

        let dateToString = date => {
            if (date && date.year && date.month) return (pickerLang.months[date.month - 1] + ' ' + date.year);
            return '?';
        }

        return (
            <div>
                <Label label="Date" />
                <Picker
                    ref="pickRange"
                    years={{ min: 2013 }} 
                    range={mrange}
                    lang={pickerLang}
                    theme="light"
                    onDismiss={this.handleRangeDissmis}
                >
                    <MonthBox value={dateToString(mrange.from) + ' - ' + dateToString(mrange.to)} onClick={this._handleClickRangeBox} />
                </Picker>
            </div>
        )
    }

    _handleClickRangeBox(e) {
        this.refs.pickRange.show()
    }
    handleRangeDissmis(value) {
        this.setState({ mrange: value })
        this.props.onChange(value);
    }
}