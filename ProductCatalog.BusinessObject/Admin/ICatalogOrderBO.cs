using ProductCatalog.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
   public interface ICatalogOrderBO 
    {
        Task<IEnumerable<CatalogOrder>> GetCatalogOrder();
        Task<CatalogOrder> Add(CatalogOrder catalogOrder);
    }
}
