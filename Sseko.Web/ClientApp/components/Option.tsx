import * as React from 'react';
import { Label } from "./Label";
import { SelectList } from './SelectList';
import { DateSelect } from './DateSelect';

interface OptionProps {
    title: string;
    onMonthChange: (value: any) => any;
}

export const Option = (props: OptionProps) =>
    <div className="option">
        <div className="optionHeader">
            <h3>{props.title}</h3>
        </div>
        <div className="optionBody">
            <div className="showLevel pull-left">
                <SelectList
                    htmlId={"showLevel"}
                    name={""}
                    error={""}
                    label={"Show Levels"}
                    options={timeOptions}
                    initialValue={timeOptions[0]}
                    clearable={false}
                    onChange={props.onMonthChange}
                />
            </div>
            <div className="date pull-left">
                <DateSelect
                    htmlId={"dateRange"}
                    error={""}
                    label={"Date"}
                />
            </div>
            <div className="applyButton">
                <button>Apply</button>
            </div>
        </div>
    </div>

const timeOptions = [
    {
        value: [0, 0],
        label: "All"
    }
]