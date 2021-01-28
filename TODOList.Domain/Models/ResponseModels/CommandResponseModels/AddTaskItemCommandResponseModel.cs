namespace TODOList.Domain.Models.ResponseModels.CommandResponseModels
{
    public class AddTaskItemCommandResponseModel
    {
        public AddTaskItemCommandResponseModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
