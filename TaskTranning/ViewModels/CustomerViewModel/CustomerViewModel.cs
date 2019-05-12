using System.ComponentModel.DataAnnotations;

namespace TaskTranning.ViewModels.CustomerViewModel
{
    public class CustomerViewModel
    {
        [Display(Name = "CustomerId")]
        public int Id { get; set; }
        
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        
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