
using ProductCatalog.Domain.Products;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public interface ICatalogLookUpBO
    {
        Task<LookUp> Add(LookUp item);
        Task<IEnumerable<LookUp>> GetLookUpItems();
       // Task<IEnumerable<string>> GetLookUpId(LookUpId id);
    }
}
