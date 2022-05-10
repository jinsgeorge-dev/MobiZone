using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.EFRepository;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin.Authentication
{
    public class AuthenticationBO: IAuthenticationBO
    {
        #region privatevariables
        //private readonly Domain.DataBase.CatalogDBContext _catalogDBContext;
        private readonly IAuthentication _authentication;
        #endregion
        public AuthenticationBO( IAuthentication authentication)
        {
            //_catalogDBContext = context;
            _authentication = authentication;
        }

        public async Task<UserDetails> AddUserRegistration(UserDetails user)
        {
            return await _authentication.Add(user);
        }

        

        public Task Edit(UserDetails user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDetails>> Get()
        {
            throw new NotImplementedException();
        }
    }

    
}
