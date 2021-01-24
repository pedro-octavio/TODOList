using AutoMapper;
using TODOList.Data.Models;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region TaskList
            CreateMap<TaskListModel, GetAllTaskListsQueryResponseModel>();
            CreateMap<TaskListModel, GetTaskListByIdQueryResponseModel>();
            CreateMap<AddTaskListCommandRequestModel, TaskListModel>();
            CreateMap<UpdateTaskListCommandRequestModel, TaskListModel>();
            #endregion

            #region TaskItem
            CreateMap<TaskItemModel, GetAllTaskItemsQueryResponseModel>();
            CreateMap<TaskItemModel, GetTaskItemByIdQueryResponseModel>();
            CreateMap<AddTaskItemCommandRequestModel, TaskItemModel>();
            CreateMap<UpdateTaskItemCommandRequestModel, TaskItemModel>();
            #endregion
        }
    }
}
