using shop_view.data.enums;
using System.ComponentModel.DataAnnotations;

namespace shop_view.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The 'First Name' field is required.")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The 'Last Name' field is required.")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The 'Email Address' field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The 'Password' field is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, and one digit.")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "The 'Confirm Password' field is required.")]
        //[Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
        //public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }
    }
}
