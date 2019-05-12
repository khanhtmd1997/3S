using System.ComponentModel.DataAnnotations;

namespace TaskTranning.ViewModels
{
    public class EditPasswordUserViewModel
    {
        public EditPasswordUserViewModel(){}

        public EditPasswordUserViewModel(UserViewModel user)
        {
            Id = user.Id;
            PassWord = user.PassWord;
            NewPassword = user.NewPassword;
            ConfirmPassword = user.ConfirmPassword;

        }
        
        [Display(Name = "User Id")]
        public int Id { get; set; }
        
        [Display(Name = "PassWord")]
        public string PassWord { get; set; }
        
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
        
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}