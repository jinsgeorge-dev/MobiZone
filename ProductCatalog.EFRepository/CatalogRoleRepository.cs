using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Products;
using ProductCatalog.Domain.Role;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICatalogRoleRepository = ProductCatalog.Repository.ICatalogRoleRepository;

namespace ProductCatalog.EFRepository
{
    public class CatalogRoleRepository : GenericRepository<Roles>, ICatalogRoleRepository
    {
        private readonly CatalogDBContext _context;

        public CatalogRoleRepository(CatalogDBContext context) : base(context)
        {
            this._context = context;
        }

        
        public async override Task<IEnumerable<Roles>> GetAll()
        {
            return await _context.Role.ToListAsync();
        }

    }
}
