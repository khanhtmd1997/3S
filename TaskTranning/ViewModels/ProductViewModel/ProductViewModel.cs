using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.ProductViewModel
{
    public class ProductViewModel
    {
        [Display(Name="ProductId")]
        public int Id { get; set; }
        
        [Display(Name="ProductName")]
        public string ProductName { get; set; }
        
        [Display(Name="BrandId")]
        public int BrandId { get; set; }
        
        [Display(Name="CategoryId")]
        public int CategoryId { get; set; }
        
        [Display(Name="ModelYear")]
        public int ModelYear { get; set; }
        
        [Display(Name="ListPrice")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal ListPrice { get; set; }
        
        [Display(Name = "Picture")]
        public string Picture { get; set; }
        
        public virtual Category Category { get; set; }
        
        public virtual ICollection<Stock> Stock { get; set; }
        
        public virtual Brand Brand { get; set; }
    }
}