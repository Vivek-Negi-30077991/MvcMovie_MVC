using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class SignUp
    {
        public int Id { get; set; }
        [Required]

        public string UserId { get; set; }
        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
    }
}
