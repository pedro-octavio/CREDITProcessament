using CREDITProcessament.Domain.Models.RequestModels;
using FluentValidation;

namespace CREDITProcessament.Domain.Validators
{
    public class GetAllProcessamentsByProcessedValidator : AbstractValidator<GetAllProcessamentsByProcessedRequestModel>
    {
        public GetAllProcessamentsByProcessedValidator()
        {
            RuleFor(x => x.Processed)
                .NotNull().WithMessage("The Processed cannot be null.");
        }
    }
}
