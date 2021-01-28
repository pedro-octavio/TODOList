export default class getTaskItemByIdQueryResponseModel {
    constructor(name: string, createDate: Date, isDone: boolean, description?: string) {
        this.name = name
        this.createDate = createDate
        this.isDone = isDone
        this.description = description
    }

    name: string
    createDate: Date
    isDone: boolean
    description?: string
}
