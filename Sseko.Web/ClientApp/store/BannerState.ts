import * as dtos from '../dtos';

export default class BannerState {
    rows: dtos.ReportForPersonalVolumeDto[];
    saleTypeFilter: string[];
    hostessFilter: string[];
    sortColumn: string;
    sortDirection: string;
    startDate: any;
    endDate: any;
    errors: string;
    loading: boolean;
}