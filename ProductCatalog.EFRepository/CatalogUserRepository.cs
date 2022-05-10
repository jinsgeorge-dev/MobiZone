using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class CatalogUserRepository : GenericRepository<User>, ICatalogUserRepository
    {
        private readonly CatalogDBContext _context;

        public CatalogUserRepository(CatalogDBContext _context) : base(_context)
        {
            this._context = _context;
        }
        public async override Task<IEnumerable<User>> GetAll()
        {
            return await _context.User.ToListAsync();
        }
    }

}
