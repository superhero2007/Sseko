import * as _ from 'lodash';

export function levelFilter(rows, levels) {
    return rows.filter((row) => _.includes(levels, row.level))
}
export function sortGrid(rows, sortColumn, sortDirection) {
    const comparer = (a, b) => {
        var item1;
        var item2;
        if (sortColumn == 'level') {
            item1 = new Number(a[sortColumn]);
            item2 = new Number(b[sortColumn]);
        } else if (sortColumn == 'commissionableSales' || sortColumn == 'pv') {
            item1 = new Number(a[sortColumn].substr(1));
            item2 = new Number(b[sortColumn].substr(1));
        } else {
            item1 = a[sortColumn];
            item2 = b[sortColumn];
        }

        if (sortDirection === 'ASC') {
            return (item1 > item2) ? 1 : -1;
        } else if (sortDirection === 'DESC') {
            return (item1 < item2) ? 1 : -1;
        }
    };
    const rowsCopy = rows;
    const newRows = sortDirection === 'NONE' ? rowsCopy.slice(0) : rowsCopy.sort(comparer);

    return newRows;
}