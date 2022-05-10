using ProductCatalog.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin
{
     public interface ICatalogUserBO
    {
        Task<IEnumerable<User>> GetUser();
    }
}
