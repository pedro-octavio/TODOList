export default class GetAllTaskListsQueryResponseModel {
    constructor(id: string, name: string, createDate: Date) {
        this.id = id
        this.name = name
        this.createDate = createDate
    }

    id: string
    name: string
    createDate: Date
}
