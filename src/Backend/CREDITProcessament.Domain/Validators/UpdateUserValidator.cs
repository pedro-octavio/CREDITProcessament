using CREDITProcessament.Domain.Models.RequestModels;
using FluentValidation;

namespace CREDITProcessament.Domain.Validators
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserRequestModel>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.CPF)
                .NotNull().WithMessage("The CPF cannot be null.")
                .NotEmpty().WithMessage("The CPF cannot be empty.")
                .Length(11).WithMessage("The of lenghtn of CPF is 11 caracters");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("The Name cannot be null.")
                .NotEmpty().WithMessage("The Name cannot be empty.")
                .MaximumLength(120).WithMessage("The maximum lenght of Name is 120 caracters");
        }
    }
}
