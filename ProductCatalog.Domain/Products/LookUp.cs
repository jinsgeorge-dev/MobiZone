using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class LookUp
    {
        [Key]
        [Column("Id", Order = 0)]
        public int Id { get; set; }

        [Column("Name", Order = 1)]
        public string name { get; set; }


        [Column("ParentId", Order = 3)]
        public LookUpId ParentId { get; set; }

        

        

        
    }
}
