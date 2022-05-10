using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class OrderDetails
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("UserId", Order = 1)]
        [Required]
        public int UserId { get; set; }
        public virtual Customers.User Users { get; set; }

        [Column("TotalAmount", Order = 2)]
        [Required]
        public int Total { get; set; }

        [Column("PaymentId", Order = 3)]
        [Required]
        public int paymentID { get; set; }
        public virtual PaymentDetails PaymentDetails { get; set; }

        [Column("CreatedDateUtc", Order = 4)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 5)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("CreatedBy", Order = 6)]
        public DateTime CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 7)]
        public DateTime ModifiedBy { get; set; }

        
      

        
    }
}
