using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.ProductViewModel
{
    public class ActionProductViewModel
    {
        public ActionProductViewModel(){}

        public ActionProductViewModel(Product product)
        {
            Id = product.Id;
            ProductName = product.ProductName;
            BrandId = product.BrandId;
            CategoryId = product.CategoryId;
            ModelYear = product.ModelYear;
            ListPrice = product.ListPrice;
        }
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
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal ListPrice { get; set; }
        
        [Display(Name="Picture")]
        public IFormFile Picture { get; set; }
    }
}