using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserDetails
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }


        [Column("FirstName", Order = 1, TypeName = "Varchar(50)")]
        [Required(ErrorMessage = "Please Enter the FirstName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "This field should not contain any numbers or special characters")]
        public string FirstName { get; set; }

        [Column("LastName", Order = 2, TypeName = "Varchar(50)")]
        [Required(ErrorMessage = "Please Enter the LastName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "This field should not contain any numbers or special characters")]
        public string LastName { get; set; }

        
        [Required(ErrorMessage = "Please Enter the valid Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z\s]+\.[a-zA-Z\s.]+$", ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }


        
        [Column("UserId", Order = 6)]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }





    }
}
