using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

using ProductCatalog.Domain.Products;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class LookUpService : ILookUpService
    {
        private string catalogServiceUrl;
        public LookUpService(IConfiguration config)
        {
            catalogServiceUrl = config["CatalogUrl"];
        }
        public async Task<bool> AddAsync(LookUp item)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string json = JsonConvert.SerializeObject(item);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(catalogServiceUrl + "/api/CatalogLookUp", content);
                return response.IsSuccessStatusCode;
            }
        }


        public async Task<IEnumerable<LookUp>> GetItemsAsync()
        {


            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(catalogServiceUrl + "/api/cataloglookup");
                var datastring = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<LookUp>>(datastring);
            }
        }






    }


}
