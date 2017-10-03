import * as dtos from '../dtos';

export default class DlReportState {
    rows: dtos.ReportForDownlineDto[];
    sortColumn: string;
    sortDirection: string;
    hostessFilter: string[];
    levelFilter: string[];
    startDate: any;
    endDate: any;
    errors: string;
    loading: boolean;
}