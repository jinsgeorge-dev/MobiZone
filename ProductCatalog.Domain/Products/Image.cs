using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class Image
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }

        [Column("image_url", Order = 1, TypeName = "Varchar(300)")]
        public string ImageUrl { get; set; }


        [Column("ProductId", Order = 2)]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Column("created_on_utc", Order = 3)]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 4)]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 5)]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 6)]
        public DateTime ModifiedBy { get; set; }
    }
}
