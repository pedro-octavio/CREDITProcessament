using CREDITProcessament.Domain.Models.RequestModels;
using FluentValidation;

namespace CREDITProcessament.Domain.Validators
{
    public class UpdateProcessamentValidator : AbstractValidator<UpdateProcessamentRequestModel>
    {
        public UpdateProcessamentValidator()
        {
            RuleFor(x => x.UserCPF)
                .NotNull().WithMessage("The CPF cannot be null.")
                .NotEmpty().WithMessage("The CPF cannot be empty.")
                .Length(11).WithMessage("The of lenghtn of CPF is 11 caracters");

            RuleFor(x => x.Score)
                .NotNull().WithMessage("The Score cannot be null");

            RuleFor(x => x.IsProcessed)
                .NotNull().WithMessage("The Processed cannot be null.");
        }
    }
}
