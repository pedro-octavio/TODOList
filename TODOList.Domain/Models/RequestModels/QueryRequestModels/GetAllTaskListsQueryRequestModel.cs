using MediatR;
using System;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllTaskListsQueryRequestModel : IRequest<GetAllTaskListsQueryResponseModel>
    {
        public GetAllTaskListsQueryRequestModel(DateTime createDate)
        {
            CreateDate = createDate;
        }

        public DateTime CreateDate { get; private set; }
    }
}
