using System.ComponentModel.DataAnnotations;

namespace TaskTranning.AllViewModels.Category
{
    public class CategoryViewModel
    {
        [Display(Name="CategoryId")]
        public int Id { get; set; }
        
        [Display(Name="CategoryName")]
        public string CategoryName { get; set; }
    }
}