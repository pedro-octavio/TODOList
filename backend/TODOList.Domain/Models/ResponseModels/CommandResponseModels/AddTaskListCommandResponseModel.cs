namespace TODOList.Domain.Models.ResponseModels.CommandResponseModels
{
    public class AddTaskListCommandResponseModel
    {
        public AddTaskListCommandResponseModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
