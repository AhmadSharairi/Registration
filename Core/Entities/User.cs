using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } 

        [Required]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Phone number is not valid")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "IC Number is required")]
        public string IcNumber { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
    }
}
