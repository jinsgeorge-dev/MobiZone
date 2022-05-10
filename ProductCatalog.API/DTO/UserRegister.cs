using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.DTO
{
    public class UserRegister
    {
       
        [Required(ErrorMessage = "Please Enter the FirstName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "This field should not contain any numbers or special characters")]
        public string FirstName { get; set; }

       
        [Required(ErrorMessage = "Please Enter the LastName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "This field should not contain any numbers or special characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter the valid Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z\s]+\.[a-zA-Z\s.]+$", ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }


       
        [Required(ErrorMessage = "Password Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
