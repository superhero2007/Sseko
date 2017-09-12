export const RowHelpers = {
    removeItem: (rows, id) => {
        var rowsCopy = [];
        Object.assign(rowsCopy, rows);

        var index = RowHelpers.indexOf(rowsCopy, id);

        rowsCopy.splice(index, 1);
        return rowsCopy;
    },

    updateItem: (rows, updated, id) => {
        var rowsCopy = [];
        Object.assign(rowsCopy, rows);

        var index = RowHelpers.indexOf(rowsCopy, id);

        var row = rowsCopy[index];
        var keys = Object.keys(updated);
        for (var x in keys) {
            row[keys[x]] = updated[keys[x]]
        }
        rowsCopy.splice(index, 1);
        rowsCopy.push(row);
        return rowsCopy;
    },

    addItem: (rows, newRow) => {
        var rowsCopy = [];
        Object.assign(rowsCopy, rows);

        rowsCopy.push(newRow);
        return rowsCopy;
    },

    toggleEnabled: (rows, id) => {
        var rowsCopy = [];
        Object.assign(rowsCopy, rows);

        var index = RowHelpers.indexOf(rows, id);

        var row = rowsCopy[index];

        var updated = { enabled: !row.enabled };

        return RowHelpers.updateItem(rows, updated, id);
    },

    guid: () => {
        function s4() {
            return Math.floor((1 + Math.random()) * 0x10000)
                .toString(16)
                .substring(1);
        }
        return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
            s4() + '-' + s4() + s4() + s4();
    },

    indexOf: (rows, id) => {
        for (var x in rows) {
            if (rows[x].id == id) {
                return rows.indexOf(rows[x]);
            }
        }
    }
}