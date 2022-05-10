using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.BusinessObject.Admin;
using ProductCatalog.BusinessObject.Admin.Authentication;
using ProductCatalog.EFRepository;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class LoadCustomerServices
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<ICatalogLookUpRepository, CatalogLookUpRepository>();
            services.AddTransient<ICatalogProductRepository, CatalogProductRepository>();
            services.AddTransient<ICatalogProductBO, CatalogProductBO>();
            services.AddTransient<Admin.ICatalogUserBO, CatalogUserBO>();
            services.AddTransient<ICatalogUserRepository, CatalogUserRepository>();
            services.AddTransient<ICatalogOrderBO, CatalogOrderBO>();
            services.AddTransient<ICatalogOrderRepository, CatalogOrderRepository>();
            services.AddTransient<IAuthentication, Authentication>();
            services.AddTransient<IAuthenticationBO, AuthenticationBO>();
        }
    }
}
