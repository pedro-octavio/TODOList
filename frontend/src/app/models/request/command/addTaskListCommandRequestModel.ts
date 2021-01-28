export default class AddTaskListCommandRequestModel {
    constructor(name: string, description?: string) {
        this.name = name
        this.description = description
    }

    name: string
    description?: string
}
