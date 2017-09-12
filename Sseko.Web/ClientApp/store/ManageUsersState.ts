import * as dtos from '../dtos';

export default class ManageUsersState {
    rows: dtos.UserDto[];
    loading: boolean,
    sortColumn: string,
    sortDirection: string,
}