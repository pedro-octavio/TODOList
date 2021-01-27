using FluentValidation;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;

namespace TODOList.Domain.Validators
{
    public class DeleteTaskListCommandValidator : AbstractValidator<DeleteTaskListCommandRequestModel>
    {
        public DeleteTaskListCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("The id cannot be null.")
                .NotEmpty().WithMessage("The id cannot be empty.")
                .Length(10).WithMessage("The length of id must be 10 caracters.");
        }
    }
}
