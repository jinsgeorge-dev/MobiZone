using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class ProductService : IProductService
    {
        private readonly string catalogServiceUrl;
        public ProductService(IConfiguration config)
        {
            catalogServiceUrl = config["CatalogUrl"];
        }
        public async Task<bool> AddProductItemsAsync(Product item)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string json = JsonConvert.SerializeObject(item);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(catalogServiceUrl + "/api/CatalogProduct", content);
                return response.IsSuccessStatusCode;
            }
        }

        public async Task<IEnumerable<Product>> GetProductItemsAsync()
        {
            var client = new HttpClient();
            var result = await client.GetAsync(catalogServiceUrl + "/api/Product/");
            var dataString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(dataString);
        }

        public async Task<IEnumerable<Product>> GetProductItemsByIdAsync(int id)
        {
            var client = new HttpClient();
            var result = await client.GetAsync(catalogServiceUrl + "/api/Product/id");
            var dataString = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(dataString);
        }
    }
}

