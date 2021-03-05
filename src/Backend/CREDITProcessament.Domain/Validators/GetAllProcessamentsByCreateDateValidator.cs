using CREDITProcessament.Domain.Models.RequestModels;
using FluentValidation;

namespace CREDITProcessament.Domain.Validators
{
    public class GetAllProcessamentsByCreateDateValidator : AbstractValidator<GetAllProcessamentsByCreateDateRequestModel>
    {
        public GetAllProcessamentsByCreateDateValidator()
        {
            RuleFor(x => x)
                .Custom((obj, context) =>
                {
                    if (obj.StartDate != null && obj.EndDate != null)
                    {
                        if (obj.StartDate > obj.EndDate)
                        {
                            context.AddFailure("The start date cannot be greater than the end date.");
                        }
                    }
                });
        }
    }
}
