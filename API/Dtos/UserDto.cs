using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class UserDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; } 

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; } 

        [Required(ErrorMessage = "IC Number is required")]
        public string IcNumber { get; set; } 
    }
}
