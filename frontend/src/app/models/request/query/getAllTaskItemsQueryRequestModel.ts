export default class GetAllTaskItemsQueryRequestModel {
    constructor(taskListId: string, createDate: Date) {
        this.taskListId = taskListId
        this.createDate = createDate
    }

    taskListId: string
    createDate: Date
}
