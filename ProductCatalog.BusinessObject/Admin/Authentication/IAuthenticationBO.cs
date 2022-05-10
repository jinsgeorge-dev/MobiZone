using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.Products;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin.Authentication
{
    public interface IAuthenticationBO
{
        
        Task<UserDetails> AddUserRegistration(UserDetails user);
        Task<IEnumerable<UserDetails>> Get();
        
        Task Edit(UserDetails user);
    }
}
