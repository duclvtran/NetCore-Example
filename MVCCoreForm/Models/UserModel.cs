using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreForm.Models
{
    public class UserModel
    {
        [RegularExpression(pattern: "^Mr\\..*|^Mrs\\..*|^Ms\\..*|^Miss\\..*", ErrorMessage = "Name must start with Mr./Mrs./Ms./Miss.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "UserName is Request")]
        [StringLength(maximumLength: 25, MinimumLength = 3, ErrorMessage = "Lengtht must between 3 to 25")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(otherProperty: "Password", ErrorMessage = "Password & confirm password does not match")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }

        [Range(minimum: 100, maximum: 200, ErrorMessage = "Please enter a valid no between 100 & 200")]
        public int Range { get; set; }

        [Required(ErrorMessage = "CreateDate is Request")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [CreditCard(ErrorMessage = "Please enter a valid card No")]
        public string CreditCard { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL")]
        public string Url { get; set; }
    }
}