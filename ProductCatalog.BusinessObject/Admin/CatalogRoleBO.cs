using Microsoft.AspNet.Identity;
using ProductCatalog.Domain.Products;
using ProductCatalog.Domain.Role;
using ProductCatalog.EFRepository;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICatalogRoleRepository = ProductCatalog.Repository.ICatalogRoleRepository;

namespace ProductCatalog.BusinessObject.Admin.Authentication
{
    public class CatalogRoleBO : ICatalogRoleBO
    {
        private readonly ICatalogRoleRepository _role;

        public CatalogRoleBO(ICatalogRoleRepository role)
        {
            this._role = role;
        }
        public async Task<IEnumerable<Roles>> GetRole()
        {
            return await _role.GetAll();
        }
    }
}
