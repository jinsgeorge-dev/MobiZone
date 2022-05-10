using ProductCatalog.Domain.Order;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class CatalogOrderBO : ICatalogOrderBO
    {
        private readonly ICatalogOrderRepository catalogOrderRepository;

        public CatalogOrderBO(ICatalogOrderRepository catalogOrderRepository)
        {
            this.catalogOrderRepository = catalogOrderRepository;
        }
        public async Task<IEnumerable<CatalogOrder>> GetCatalogOrder()
        {
            return await catalogOrderRepository.GetAll();
        }
        public async Task<CatalogOrder> Add(CatalogOrder catalogOrder)
        {
            return await catalogOrderRepository.Add(catalogOrder);
        }

       
    }
}
