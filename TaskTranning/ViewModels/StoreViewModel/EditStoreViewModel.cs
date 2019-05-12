using System.ComponentModel.DataAnnotations;

namespace TaskTranning.ViewModels
{
    public class EditStoreViewModel
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
    }
}