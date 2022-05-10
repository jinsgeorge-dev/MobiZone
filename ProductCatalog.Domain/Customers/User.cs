using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class User
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("UserName", Order = 1)]
        [Required(ErrorMessage ="UserName Required")]
        public string UserName { get; set; }

        [Column("Password", Order = 2)]
        [Required(ErrorMessage = "Password Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Column("ForgotToken", Order = 3)]
        [Required]
        public string ForgotToken { get; set; }

        [Column("RoleId", Order = 4)]
        [ForeignKey("Role")]
        [Required]
        public int RoleId { get; set; }
        public virtual Role.Roles Role  { get; set; }

        [Column("CreatedDateUtc", Order = 5)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 6)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("CreatedBy", Order = 7)]
        [Required]
        public string CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 8)]
        [Required]
        public string ModifiedBy { get; set; }


        
       
        public virtual ICollection<Cart.CartItem> CartItems { get; set; }
        public virtual ICollection<Order.OrderDetails> OrderDetails { get; set; }
    }
}
