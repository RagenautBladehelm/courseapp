using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "pass between 3 and 9")]
        public string Password { get; set; }
    }
}