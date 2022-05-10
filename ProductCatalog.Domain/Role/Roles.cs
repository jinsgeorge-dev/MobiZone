using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Role
{
    public class Roles
    {
        [Key]
        [Column("Id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("Roles", Order = 1, TypeName = "Varchar(50)")]
        [Required]
        public string UserRole { get; set; }

        

        [Column("CreatedDateUtc", Order = 2)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("UpdatedDateUtc", Order = 3)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("CreatedBy", Order = 4, TypeName = "Varchar(50)")]
        public string CreatedBy { get; set; }

        [Column("UpdatedBy", Order = 6, TypeName = "Varchar(50)")]
        public string ModifiedBy { get; set; }



       
        
    }
}
