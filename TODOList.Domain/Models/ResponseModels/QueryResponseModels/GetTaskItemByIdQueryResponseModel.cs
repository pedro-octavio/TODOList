using System;

namespace TODOList.Domain.Models.ResponseModels.QueryResponseModels
{
    public class GetTaskItemByIdQueryResponseModel
    {
        public GetTaskItemByIdQueryResponseModel(string name, string description, DateTime createDate, bool isDone)
        {
            Name = name;
            Description = description;
            CreateDate = createDate;
            IsDone = isDone;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDate { get; private set; }
        public bool IsDone { get; private set; }
    }
}
