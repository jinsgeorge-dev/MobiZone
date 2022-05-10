using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class CatalogOrder
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("ProductId", Order = 1)]
        [Required]
        public int product_id { get; set; }
        public virtual Products.Product Product { get; set; }

        [Column("LookUpId", Order = 2)]
        [Required]
        public int LookUpId { get; set; }
        public virtual Products.LookUp LookUp { get; set; }

        [Column("Quantity", Order = 3)]
        [Required]
        public int Quantity { get; set; }

        [Column("Price", Order = 4)]
        [Required]
        public decimal Price { get; set; }

        [Column("OrderDetailsId", Order = 5)]
        public int OrderDetailsId { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }

        [Column("createdDateUtc", Order = 6)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 7)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("CreatedBy", Order = 8)]
        [Required]
        public DateTime CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 9)]
        [Required]
        public DateTime ModifiedBy { get; set; }

        

        
    }
}
