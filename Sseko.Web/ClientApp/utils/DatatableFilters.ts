import * as _ from 'lodash';

export function levelFilterer(rows, levels) {
    if (levels.length == 0)
        return rows;
    return rows.filter((row) => _.includes(levels, row.level));
}

export function typeFilterer(rows, types) {
    if (types.length == 0)
        return rows;
    var filteredRows = rows.filter((row) => _.includes(types, row.type));
    
    if (_.includes(types, "Other"))
        for (var x in rows)
            if (rows[x].type == "")
                filteredRows.push(rows[x]);

    return filteredRows;
}

export function hostessFilterer(rows, hostesses)
{
    if (hostesses.length == 0)
        return rows;
    return rows.filter((row) => _.includes(hostesses, row.hostess));
}

export function sortGrid(rows, sortColumn, sortDirection) {
    const comparer = (a, b) => {
        var item1;
        var item2;
        if (sortColumn == 'level' || sortColumn == 'orderNumber') {
            item1 = new Number(a[sortColumn]);
            item2 = new Number(b[sortColumn]);
        } else if (sortColumn == 'commissionableSales' || sortColumn == 'pv' || sortColumn == 'commission' || sortColumn == 'sale') {
            item1 = new Number(a[sortColumn].substr(1));
            item2 = new Number(b[sortColumn].substr(1));
        } else if(sortColumn == 'date') {
            item1 = new Date(a[sortColumn]);
            item2 = new Date(b[sortColumn]);
        }else {
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