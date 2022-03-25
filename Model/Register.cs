using System.ComponentModel.DataAnnotations;

namespace AspNet_Core_Identity.Model
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password and confirm password doesnot match")]
        public string ConfirmPassword{get;set;}
        
        
    }
}