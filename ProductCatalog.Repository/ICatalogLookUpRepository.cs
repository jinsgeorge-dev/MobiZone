using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Repository
{
    public interface ICatalogLookUpRepository : IGenericRepository<LookUp>
    {
       // Task<IEnumerable<string>> GetByParentId(LookUpId id);
    }
}
