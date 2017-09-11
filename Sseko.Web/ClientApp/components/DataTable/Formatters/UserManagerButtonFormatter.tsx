import * as React from 'react';
import { DisableButton } from './Buttons/DisableButton';
import { EnableButton } from './Buttons/EnableButton';
import { ImpersonateButton } from './Buttons/ImpersonateButton';
import { ResetPasswordButton } from './Buttons/ResetPasswordButton';

export class UserManagerButtonFormatter extends React.Component<FormatterProps, {}> {
    render() {
        let props = this.props.value;
        return (
            <div>
                {props.disable && <DisableButton id={props.id} onDisable={props.disable.onClick} />}
                {props.enable && <EnableButton id={props.id} onEnable={props.enable.onClick} />}
                {props.resetPassword && <ResetPasswordButton id={props.id} onReset={props.resetPassword.onClick} />}
                {props.impersonate && <ImpersonateButton id={props.id} onImpersonate={props.impersonate.onClick} />}
            </div>
        );
    }
}

export interface FormatterProps {
    value: {
        id: string,
        disable: any;
        enable: any;
        resetPassword: any;
        impersonate: any;
    }
}
