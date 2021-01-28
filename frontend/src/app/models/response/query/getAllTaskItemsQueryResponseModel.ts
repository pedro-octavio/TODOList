export default class GetAllTaskItemsQueryResponseModel {
    constructor(id: string, name: string, createDate: Date, isDone: boolean) {
        this.id = id
        this.name = name
        this.createDate = createDate
        this.isDone = isDone
    }

    id: string
    name: string
    createDate: Date
    isDone: boolean
}
