using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Cart
{
    public class CartItem
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("LookUpId", Order = 1)]
        [Required]
        public int LookUpId { get; set; }
        public virtual Products.LookUp LookUp { get; set; }

        [Column("UserId", Order = 2)]
        [Required]
        public int UserId { get; set; }
        public virtual Customers.User User { get; set; }

        [Column("Quantity", Order = 3)]
        [Required]
        public int Quantity { get; set; }

        [Column("CreatedDateUtc", Order = 4)]
        public DateTime CreatedOnUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 5)]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("CreatedBy", Order = 6)]
        public DateTime CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 7)]
        public DateTime ModifiedBy { get; set; }
    }
}
