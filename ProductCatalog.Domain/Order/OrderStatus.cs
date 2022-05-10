using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class OrderStatus
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("OrderId", Order = 1)]
        [Required]
        public int OrderId { get; set; }
        public virtual CatalogOrder CatalogOrder { get; set; }

        [Column("OrderStatus", Order = 2)]
        [Required]
        public Status Status { get; set; }

        [Column("CreatedDateUtc", Order = 3)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("UpdetedDateUtc", Order = 4)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("Createdby", Order = 5)]
        public string CreatedBy { get; set; }

        [Column("UpdetedBy", Order = 6)]
        public string ModifiedBy { get; set; }
    }
}
