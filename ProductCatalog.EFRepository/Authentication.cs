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
   public class Authentication : GenericRepository<UserDetails>, IAuthentication
    {
        IGenericRepository<UserDetails> _userRepo;
        private readonly CatalogDBContext _context;
        public Authentication(CatalogDBContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<UserDetails> Add(UserDetails user)
        {
            try
            {
                _context.UserDetails.Add(user);

                await _context.SaveChangesAsync();
                return user;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
