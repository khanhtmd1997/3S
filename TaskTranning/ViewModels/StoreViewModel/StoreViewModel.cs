using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    public class StoreViewModel 
    {
        [Display(Name = "StoreId")]
        public int Id { get; set; }
        
        [Display(Name = "StoreName")]
        public string StoreName { get; set; }
        
        [Display(Name = "Phone")]
        public int Phone { get; set; }
        
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Display(Name = "Street")]
        public string Street { get; set; }
        
        [Display(Name = "City")]
        public string City { get; set; }
        
        [Display(Name = "State")]
        public string State { get; set; }
        
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }
        
        public virtual ICollection<User> User { get; set; }
        
        public virtual ICollection<Stock> Stock { get; set; }
    }
}