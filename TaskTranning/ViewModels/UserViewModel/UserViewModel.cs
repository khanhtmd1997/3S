using System.ComponentModel.DataAnnotations;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    
    public class UserViewModel
    {   
        [Display(Name = "User Id")]
        public int Id { get; set; }
        
        [Display(Name = "Email")]
        public string Email{ get; set; }
        
        [Display(Name = "PassWord")]
        public string PassWord { get; set; }
        
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
        
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        
        [Display(Name = "Phone")]
        public int Phone { get; set; }
        
        [Display(Name = "Address")]
        public string Address { get; set; }
        
        [Display(Name = "Picture")]
        public string Picture { get; set; }
        
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        
        [Display(Name = "Store Name")]
        public int StoreId { get; set; }
        
        public virtual Store Store { get; set; }
    }
}