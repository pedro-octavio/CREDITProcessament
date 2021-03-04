using CREDITProcessament.Domain.Models.RequestModels;
using FluentValidation;

namespace CREDITProcessament.Domain.Validators
{
    public class DeleteRangeProcessamentValidator : AbstractValidator<DeleteRangeProcessamentRequestModel>
    {
        public DeleteRangeProcessamentValidator()
        {
            RuleForEach(x => x.CPFs)
                .NotNull().WithMessage("The CPF cannot be null.")
                .NotEmpty().WithMessage("The CPF cannot be empty.")
                .Length(11).WithMessage("The of lenghtn of CPF is 11 caracters");
        }
    }
}
