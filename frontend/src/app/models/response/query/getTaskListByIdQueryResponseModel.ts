export default class getTaskListByIdQueryResponseModel {
    constructor(name: string, createDate: Date, description?: string) {
        this.name = name
        this.createDate = createDate
        this.description = description
    }

    name: string
    createDate: Date
    description?: string
}
