using FluentValidation;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;

namespace TODOList.Domain.Validators
{
    public class GetAllTaskItemsQueryValidator : AbstractValidator<GetAllTaskItemsQueryRequestModel>
    {
        public GetAllTaskItemsQueryValidator()
        {
            RuleFor(x => x.TaskListId)
                .NotNull().WithMessage("The task list id cannot be null.")
                .NotEmpty().WithMessage("The task list id cannot be empty.")
                .Length(10).WithMessage("The length of task list id must be 10 caracters.");
        }
    }
}
