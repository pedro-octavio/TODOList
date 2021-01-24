using System;

namespace TODOList.Domain.Models.ResponseModels.QueryResponseModels
{
    public class GetTaskListByIdQueryResponseModel
    {
        public GetTaskListByIdQueryResponseModel(string name, string description, DateTime createDate)
        {
            Name = name;
            Description = description;
            CreateDate = createDate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}
