using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.StockViewModel
{
    public class StockViewModel
    {
        [Key]
        [Display(Name="StoreId")]
        public int StoreId { get; set; }
        
        [Key]
        [Display(Name="ProductId")]
        public int ProductId { get; set; }
        
        [Display(Name="Quantity")]
        public int Quantity { get; set; }
        
        public virtual Product Product { get; set; }
        
        public virtual Store Store { get; set; }

    }
}