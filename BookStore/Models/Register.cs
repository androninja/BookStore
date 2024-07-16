using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BookStore.Models
{
    public class Register
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Entered Passwords Don't match")]
        public string ConfirmPassword { get; set; } 
    }
}
