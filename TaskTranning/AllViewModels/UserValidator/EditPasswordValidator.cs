﻿using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.ViewModels;

namespace TaskTranning.AllViewModels
{
    public class EditPasswordValidator : AbstractValidator<EditPasswordUserViewModel>
    {
        public EditPasswordValidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.NewPassword).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.NewPassword).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(_resourcesServices.GetLocalizedHtmlString("Contain both letters and numbers"));
            RuleFor(x => x.NewPassword).MaximumLength(100).WithMessage(_resourcesServices.GetLocalizedHtmlString("Maxlength 100 characters"));
            RuleFor(x => x.NewPassword).MinimumLength(6).WithMessage(_resourcesServices.GetLocalizedHtmlString("Minlength 6 characters"));
            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.ConfirmPassword).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(_resourcesServices.GetLocalizedHtmlString("Contain both letters and numbers"));
            RuleFor(x => x.ConfirmPassword).MaximumLength(100).WithMessage(_resourcesServices.GetLocalizedHtmlString("Maxlength 100 characters"));
            RuleFor(x => x.ConfirmPassword).MinimumLength(6).WithMessage(_resourcesServices.GetLocalizedHtmlString("Minlength 6 characters"));
            RuleFor(x => x.ConfirmPassword).Equal(x => x.NewPassword)
                .WithMessage(_resourcesServices.GetLocalizedHtmlString("Confirm Password must equal New Password"));
        }
    }
}