using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel(){}
        public EditUserViewModel(User user)
        {
            Id = user.Id;
            Email = user.Email;
            FullName = user.FullName;
            Phone = user.Phone;
            Address = user.Address;
            IsActive = user.IsActive;
            StoreId = user.StoreId;

        }
        
        [Display(Name = "User Id")]
        public int Id { get; set; }
            
        [Display(Name = "Email")]
        public string Email{ get; set; }       
            
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
            
        [Display(Name = "Phone")]
        public int Phone { get; set; }  
        
        [Display(Name = "Picture")]
        public IFormFile Picture { get; set; }
        
        [Display(Name = "Address")]
        public string Address { get; set; }
            
        [Display(Name = "IsActive")]
        public bool IsActive { get; set; }
        
        [Display(Name = "Store Name")]
        public int StoreId { get; set; }
        
    }
}