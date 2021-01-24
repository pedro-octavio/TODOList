using System;

namespace TODOList.Domain.Models.ResponseModels.QueryResponseModels
{
    public class GetAllTaskListsQueryResponseModel
    {
        public GetAllTaskListsQueryResponseModel(string id, string name, DateTime createDate)
        {
            Id = id;
            Name = name;
            CreateDate = createDate;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}
