using ShopTARge22.Utilities;
using System.ComponentModel.DataAnnotations;

namespace ShopTARge22.Models.Accounts
{
    public class RegisterViewModel
    {

        [Required]
        [EmailAddress]
        [ValidEmailDomain(allowedDomain: "gmail.com", ErrorMessage ="Must be gmail.com")]
        public string Email;


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage ="Password and confirmation password do not match")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
    }
}
