using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.ProductViewModel;

namespace TaskTranning.AllViewModels
{
    public class ActionProductValidator : AbstractValidator<ActionProductViewModel>
    {
        public ActionProductValidator(IProductServices _productServices, ResourcesServices _resourcesServices)
        {
            RuleFor(x => x.ProductName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.ListPrice).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.ModelYear).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.Picture).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
        }
        
    }
}