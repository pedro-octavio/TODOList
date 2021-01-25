using MediatR;
using System;
using System.Collections.Generic;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllTaskListsQueryRequestModel : IRequest<IEnumerable<GetAllTaskListsQueryResponseModel>>
    {
        public DateTime CreateDate { get; set; }
    }
}
