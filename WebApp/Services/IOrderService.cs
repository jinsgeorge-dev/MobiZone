using ProductCatalog.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<CatalogOrder>> GetCatalogOrder();
    }
}
