using ProductCatalog.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface ILoginService
    {
        Task<string> Login(UserLogin credential);
    }
}
