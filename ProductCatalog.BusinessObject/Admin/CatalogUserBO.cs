using ProductCatalog.Domain.Customers;
using ProductCatalog.EFRepository;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin
{
      public class CatalogUserBO : ICatalogUserBO
    
        {
        private readonly ICatalogUserRepository _catalogUserRepository;

        public CatalogUserBO(ICatalogUserRepository catalogItemRepository)
        {
            this._catalogUserRepository = catalogItemRepository;
        }

        public async Task<IEnumerable<User>> GetUser()
        {
            return await _catalogUserRepository.GetAll();
        }
    }
}

