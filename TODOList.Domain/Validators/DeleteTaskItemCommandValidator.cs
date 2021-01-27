using FluentValidation;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;

namespace TODOList.Domain.Validators
{
    public class DeleteTaskItemCommandValidator : AbstractValidator<DeleteTaskItemCommandRequestModel>
    {
        public DeleteTaskItemCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("The id cannot be null.")
                .NotEmpty().WithMessage("The id cannot be empty.")
                .Length(10).WithMessage("The length of id must be 10 caracters.");
        }
    }
}
