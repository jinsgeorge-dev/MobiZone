using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class PaymentDetails
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }


        [Column("Amount", Order = 1,TypeName ="Decimal(12,3)")]
        [Required]
        public int Amount { get; set; }

        [Column("PaymentStatus", Order = 2)]
        [Required]
        public string PaymentStatus { get; set; }

        [Column("OrderId", Order = 3)]
        [Required]
        public int OrderId { get; set; }
        public virtual CatalogOrder CatalogOrder { get; set; }

        [Column("CreatedDateUtc", Order = 4)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("ModifiedDateUtc", Order = 5)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("CreatedBy", Order = 6)]
        public DateTime CreatedBy { get; set; }

        [Column("ModifiedBy", Order = 7)]
        public DateTime ModifiedBy { get; set; }
    }
}
