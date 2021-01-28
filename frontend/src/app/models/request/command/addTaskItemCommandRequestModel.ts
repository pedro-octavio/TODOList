export default class addTaskItemCommandRequestModel {
    constructor(taskListId: string, name: string, description?: string) {
        this.taskListId = taskListId
        this.name = name
        this.description = description
    }

    taskListId: string
    name: string
    description?: string
}
