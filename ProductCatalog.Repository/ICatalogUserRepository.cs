using ProductCatalog.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Repository
{
    public interface ICatalogUserRepository : IGenericRepository<User>
    {
    }
}
