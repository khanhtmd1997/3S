using FluentValidation;
using TaskTranning.Resources;
using TaskTranning.Services.Interface;

namespace TaskTranning.AllViewModels.Category
{
    public class CategoryValidator : AbstractValidator<CategoryViewModel>
    {
        public CategoryValidator(ResourcesServices _resourcesServices, ICategoryServices _categoryServices)
        {
            var categories = _categoryServices.GetCategories();
            foreach (var category in categories)
            {
                RuleFor(x => x.CategoryName).NotEqual(category.CategoryName).WithMessage(_resourcesServices.GetLocalizedHtmlString("Already exists"));               
            }
            RuleFor(x => x.CategoryName).NotNull().WithMessage(_resourcesServices.GetLocalizedHtmlString("Not Null"));
        }
    }
}