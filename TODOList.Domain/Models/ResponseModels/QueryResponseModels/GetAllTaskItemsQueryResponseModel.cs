using System;

namespace TODOList.Domain.Models.ResponseModels.QueryResponseModels
{
    public class GetAllTaskItemsQueryResponseModel
    {
        public GetAllTaskItemsQueryResponseModel(string id, string name, DateTime createDate, bool isDone)
        {
            Id = id;
            Name = name;
            CreateDate = createDate;
            IsDone = isDone;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreateDate { get; private set; }
        public bool IsDone { get; private set; }
    }
}
