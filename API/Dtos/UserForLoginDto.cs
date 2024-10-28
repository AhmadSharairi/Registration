using System.ComponentModel.DataAnnotations;


public class UserForLoginDto
{ 
       [Required(ErrorMessage = "IC Number is required")]
        public string IcNumber { get; set; }

}
