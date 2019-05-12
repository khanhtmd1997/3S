using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.BrandViewModel;

namespace TaskTranning.AllViewModels.BrandValidator
{
    public class BrandValidator : AbstractValidator<BrandViewModel>
    {
        public BrandValidator(ResourcesServices _resourcesServices, IBrandServices _brandServices)
        {
            var brands = _brandServices.GetBrands();
            
            foreach (var brand in brands)
            {
                RuleFor(x => x.BrandName).NotEqual(brand.BrandName).WithMessage(_resourcesServices.GetLocalizedHtmlString("Already exists"));  
            }
            RuleFor(x => x.BrandName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
        }
    }
}