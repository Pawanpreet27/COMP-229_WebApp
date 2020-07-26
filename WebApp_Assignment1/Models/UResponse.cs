using System.ComponentModel.DataAnnotations;
namespace WebApp_Assignment1.Models
{
    public class UResponse
    {
        [Key]
        public int UResponsesID { get; set; }

        [Required(ErrorMessage ="Please enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Email-ID")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email address")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number")]
        [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Please enter a valid Phone Number eg: (xxx) xxx-xxxx")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }

    }
}
