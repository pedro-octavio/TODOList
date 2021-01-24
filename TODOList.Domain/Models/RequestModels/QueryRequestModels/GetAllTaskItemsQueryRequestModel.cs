﻿using MediatR;
using System;
using System.Collections.Generic;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllTaskItemsQueryRequestModel : IRequest<IEnumerable<GetAllTaskItemsQueryResponseModel>>
    {
        public GetAllTaskItemsQueryRequestModel(string id, DateTime createDate)
        {
            Id = id;
            CreateDate = createDate;
        }

        public string Id { get; private set; }
        public DateTime CreateDate { get; private set; }

    }
}
