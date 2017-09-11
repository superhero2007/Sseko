import * as dtos from '../dtos';

export default class DlReportState {
    rows: dtos.ReportForDownlineDto[];
    sortColumn: string;
    sortDirection: string;
    levelFilter: string[];
    errors: string;
    loading: boolean;
}