export default class GetTaskListByIdQueryResponseModel {
    constructor(name: string, createDate: Date, description?: string) {
        this.name = name
        this.createDate = createDate
        this.description = description
    }

    name: string
    createDate: Date
    description?: string
}
