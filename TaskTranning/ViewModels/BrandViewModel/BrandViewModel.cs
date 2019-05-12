using System.ComponentModel.DataAnnotations;

namespace TaskTranning.ViewModels.BrandViewModel
{
    public class BrandViewModel
    {
        [Display(Name = "BrandId")]
        public int Id { get; set; }
        
        [Display(Name = "BrandName")]
        public string BrandName { get; set; }
    }
}