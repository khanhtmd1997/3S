using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TaskTranning.ViewModels
{
    public class AddUserViewModel
    {
        [Display(Name = "Email")]
        public string Email{ get; set; }
        
        [Display(Name = "PassWord")]
        public string PassWord { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
        [Display(Name = "Phone")]
        public int Phone { get; set; }
        
        [Display(Name = "Address")]
        public string Address { get; set; }
        
        [Display(Name = "Picture")]
        public IFormFile Picture { get; set; }
        
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        
        [Display(Name = "Store Name")]
        public int StoreId { get; set; }
        
    }
}