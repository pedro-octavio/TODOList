using FluentValidation;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;

namespace TODOList.Domain.Validators
{
    public class UpdateTaskListCommandValidator : AbstractValidator<UpdateTaskListCommandRequestModel>
    {
        public UpdateTaskListCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("The id cannot be null.")
                .NotEmpty().WithMessage("The id cannot be empty.")
                .Length(10).WithMessage("The length of id must be 10 caracters.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("The name cannot be null.")
                .NotEmpty().WithMessage("The name cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of name is 40 caracters.");

            RuleFor(x => x.Description)
                .MaximumLength(4200).WithMessage("The maximum length of description is 4200 caracters.");
        }
    }
}
