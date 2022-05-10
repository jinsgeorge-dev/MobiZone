using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class Product
    {
        [Key]
        [Column("Id",Order = 0)]
        public int Id { get; set; }

        [Column("Name",Order = 1, TypeName = "Varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column("SpecificationId",Order = 2)]
        [ForeignKey("Specification")]
        public int SpecificationId { get; set; }
        public Specification Specification { get; set; }

        [Column("Price",Order = 3,TypeName ="Decimal(12,3)")]
        [Required]
        public decimal Price { get; set; }



        [Column("AvailableStock",Order = 4)]
        [Required]
        public int AvailableStock { get; set; }

        [Column("IsActive",Order = 5, TypeName = "Varchar(50)")]
        [Required]
        public string IsActive { get; set; }


        [Column("createdDateUtc",Order = 6)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 7)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("DeletedByUtc", Order = 8)]
        [Required]
        public DateTime DeletedOnUTC { get; set; }

        [Column("CreatedBy",Order = 9)]
        [Required]
        public DateTime CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 10)]
        [Required]
        public DateTime ModifiedBy { get; set; }

        //navigation 
        public virtual ICollection<Image> Images { get; set; }

        public int LookUpId { get; set; }
        public virtual LookUp LookUp { get; set; }
    }
}
