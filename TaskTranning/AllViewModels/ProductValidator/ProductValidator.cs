using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels.ProductViewModel;

namespace TaskTranning.AllViewModels
{
    public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator(ResourcesServices _resourcesServices, IProductServices _productServices)
        {
            var products = _productServices.GetProducts();
            foreach (var product in products)
            {
                RuleFor(x => x.ProductName).NotEqual(product.ProductName).WithMessage(_resourcesServices.GetLocalizedHtmlString("Already exists"));
            }
            RuleFor(x => x.ProductName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.ListPrice).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.ModelYear).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.Picture).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
        }
    }
}