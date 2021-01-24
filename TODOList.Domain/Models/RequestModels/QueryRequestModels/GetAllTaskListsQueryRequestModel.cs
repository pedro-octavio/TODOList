using MediatR;
using System;
using System.Collections.Generic;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllTaskListsQueryRequestModel : IRequest<IEnumerable<GetAllTaskListsQueryResponseModel>>
    {
        public GetAllTaskListsQueryRequestModel(DateTime createDate)
        {
            CreateDate = createDate;
        }

        public DateTime CreateDate { get; private set; }
    }
}
