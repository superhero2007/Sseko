export function RowButtonFormatter(rows, callBacks: { impersonate: any, resetPassword: any, toggleEnable: any }) {
    for (var x in rows) {
        var row = rows[x];

        row.actions = {
            id: row.id
        }
        if (!row.enabled) {
            row.actions.enable = {};
            row.actions.enable.onClick = callBacks.toggleEnable(row.id);
        } else {
            row.actions.enable = null;
            row.actions.impersonate = {};
            row.actions.impersonate.onClick = callBacks.impersonate(row.id);

            row.actions.resetPassword = {};
            row.actions.resetPassword.onClick = callBacks.resetPassword(row.id);

            row.actions.disable = {};
            row.actions.disable.onClick = callBacks.toggleEnable(row.id);
        }
    }
    return rows;
}