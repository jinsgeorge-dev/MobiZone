using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class Specification
    {
        [Key]
        [Column("Id", Order = 0)]
        public int Id { get; set; }

        [Column("Version", Order = 1, TypeName = "Varchar(50)")]
        public string Version { get; set; }

        [Column("OsSupported", Order = 2, TypeName = "Varchar(100)")]
        public string OsSupported { get; set; }

        [Column("SystemRequirement", Order = 3, TypeName = "Varchar(100)")]
        public string SystemRequirement { get; set; }

        [Column("SimType", Order = 4, TypeName = "Varchar(100)")]
        public string SimType { get; set; }

        [Column("HybridSlot", Order = 5, TypeName = "Varchar(100)")]
        public string HybridSlot { get; set; }

        [Column("DisplaySize", Order = 6, TypeName = "Varchar(100)")]
        public string DisplaySize { get; set; }

        [Column("Resolution", Order = 7, TypeName = "Varchar(100)")]
        public string Resolution { get; set; }

        [Column("ResolutionType", Order = 8, TypeName = "Varchar(100)")]
        public string ResolutionType { get; set; }

        [Column("DisplayType", Order = 9, TypeName = "Varchar(100)")]
        public string DisplayType { get; set; }

        [Column("OtherFeatures", Order = 10, TypeName = "Varchar(500)")]
        public string OtherFeatures { get; set; }

       

    }
}
