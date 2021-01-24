﻿using MediatR;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetTaskListByIdQueryRequestModel : IRequest<GetTaskListByIdQueryResponseModel>
    {
        public GetTaskListByIdQueryRequestModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
