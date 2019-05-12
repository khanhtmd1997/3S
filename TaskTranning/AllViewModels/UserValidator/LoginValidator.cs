using FluentValidation;
using TaskTranning.ViewModels;
using TaskTranning.Resources;

namespace TaskTranning.AllViewModels
{
    public class LoginVadidator : AbstractValidator<LoginViewModel>
    {
        public LoginVadidator(ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.Email).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.Email).Length(1, 50).WithMessage(_resourcesServices.GetLocalizedHtmlString("To 1 between 50 characters"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(_resourcesServices.GetLocalizedHtmlString("Formatted by email"));
            RuleFor(x => x.PassWord).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.PassWord).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage(_resourcesServices.GetLocalizedHtmlString("Contain both letters and numbers"));
            RuleFor(x => x.PassWord).MaximumLength(100).WithMessage(_resourcesServices.GetLocalizedHtmlString("Maxlength 100 characters"));
            RuleFor(x => x.PassWord).MinimumLength(6).WithMessage(_resourcesServices.GetLocalizedHtmlString("Minlength 6 characters"));
        }
        
    }
}