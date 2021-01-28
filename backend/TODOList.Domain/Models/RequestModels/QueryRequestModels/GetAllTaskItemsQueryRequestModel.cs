using MediatR;
using System;
using System.Collections.Generic;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllTaskItemsQueryRequestModel : IRequest<IEnumerable<GetAllTaskItemsQueryResponseModel>>
    {
        public string TaskListId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
