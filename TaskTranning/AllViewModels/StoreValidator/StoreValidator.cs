using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;
using TaskTranning.ViewModels;

namespace TaskTranning.AllViewModels.Store
{
    public class StoreValidator : AbstractValidator<StoreViewModel>
    {
        public StoreValidator(ResourcesServices _resourcesServices,IStoreServices _storeServices)
        {
            var stores = _storeServices.GetStores();
            foreach (var store in stores)
            {
                RuleFor(x => x.Email).NotEqual(store.Email).WithMessage(_resourcesServices.GetLocalizedHtmlString("Already exists"));
            }
            RuleFor(x => x.StoreName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.Phone).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.Email).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(_resourcesServices.GetLocalizedHtmlString("Formatted by email"));
            RuleFor(x => x.Street).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.City).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
            RuleFor(x => x.ZipCode).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
               
        }
    }
}