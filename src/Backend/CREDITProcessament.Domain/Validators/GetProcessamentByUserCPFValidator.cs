﻿using CREDITProcessament.Domain.Models.RequestModels;
using FluentValidation;

namespace CREDITProcessament.Domain.Validators
{
    public class GetProcessamentByUserCPFValidator : AbstractValidator<GetProcessamentByUserCPFRequestModel>
    {
        public GetProcessamentByUserCPFValidator()
        {
            RuleFor(x => x.CPF)
                .NotNull().WithMessage("The CPF cannot be null.")
                .NotEmpty().WithMessage("The CPF cannot be empty.")
                .Length(11).WithMessage("The of lenghtn of CPF is 11 caracters");
        }
    }
}
