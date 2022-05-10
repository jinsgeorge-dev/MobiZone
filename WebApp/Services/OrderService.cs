using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductCatalog.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class OrderService : IOrderService
    {
        private string catalogUrl;

        public OrderService(IConfiguration config)
        {
            catalogUrl = config["catalogUrl"];
        }
        public async Task<IEnumerable<CatalogOrder>> GetCatalogOrder()
        {
            var client = new HttpClient();
            var result = await client.GetAsync(catalogUrl + "/api/GetCatalogOrder/");
            var dataString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<CatalogOrder>>(dataString);
        }

    }
}
