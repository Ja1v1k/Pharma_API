using System.ComponentModel.DataAnnotations;

namespace Pharma.Dtos
{
    public class ResetPasswordDto
    {
        [Required]
        public string Password { get; set; } = null!;

        [Compare("Password", ErrorMessage ="The password and confirmation password doesn't match."),]
        public string ConfirmPassword { get; set; } = null!;

        public string Email { get; set; }  = null!;

        public string Token { get; set; } = null!;
    }
}
