export default class UpdateTaskItemCommandRequestModel {
    constructor(id: string, name: string, isDone: boolean, description?: string) {
        this.id = id
        this.name = name
        this.isDone = isDone
        this.description = description
    }

    id: string
    name: string
    description?: string
    isDone: boolean
}
