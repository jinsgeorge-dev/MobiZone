using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Order;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
   public  class CatalogOrderRepository : GenericRepository<CatalogOrder>, ICatalogOrderRepository
    {
        private readonly CatalogDBContext _context;

        public CatalogOrderRepository(CatalogDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<CatalogOrder> Add(CatalogOrder item)
        {
            _context.CatalogOrder.Add(item);

            await _context.SaveChangesAsync();
            return item;
        }
    }
}
