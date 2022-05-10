using ProductCatalog.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Repository
{
    public interface ICatalogOrderRepository : IGenericRepository<CatalogOrder>
    {
    }
}
