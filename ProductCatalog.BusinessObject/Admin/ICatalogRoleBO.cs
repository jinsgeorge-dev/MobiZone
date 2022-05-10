using ProductCatalog.Domain.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin.Authentication
{
    public interface ICatalogRoleBO
    {
        Task<IEnumerable<Roles>> GetRole();
    }
}
