using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserAddress
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("Address", Order = 1, TypeName = "varchar(500)")]
        [Required(ErrorMessage = "Please Enter the Address")]
        public string Address { get; set; }

        [Column("Contact", Order = 2, TypeName = "bigInt")]
        [Required(ErrorMessage = "Please Enter Contact Number")]
        [RegularExpression(@"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)")]
        public long Contact { get; set; }

        [Column("Contact", Order = 3, TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Please Enter the Country")]
        public string country { get; set; }

        [Column("Contact", Order = 4, TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Please Enter the State")]
        public string state { get; set; }

        [Column("Contact", Order = 5, TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Please Enter the City")]
        public string city { get; set; }

        [Column("Contact", Order = 6, TypeName = "int(50)")]
        [Required(ErrorMessage = "Please Enter the Correct Pincode")]
        public int pincode { get; set; }

        [Column("UserId", Order = 7)]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
