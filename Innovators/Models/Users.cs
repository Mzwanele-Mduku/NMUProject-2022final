using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace Innovators.Models
{
    public class Users
    {

        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please enter your Name!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your Surname!")]
        public string UserSurname { get; set; }

        [Required(ErrorMessage = "Please enter your Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your password")]

        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

        //this property isto be used when deleting or deactivating and activating a user
        public string Status { get; set; }
        public string Role { get; set; }
        public string StudentNumber { get; set; }
    }
}
