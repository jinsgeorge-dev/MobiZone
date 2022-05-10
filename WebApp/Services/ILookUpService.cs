using ProductCatalog.Domain.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface ILookUpService 
    {
         Task<IEnumerable<LookUp>> GetItemsAsync();

      
        Task<bool> AddAsync(LookUp item);
    }
}
