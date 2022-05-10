using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductCatalog.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class LoginService :ILoginService
    {
        private string catalogServiceUrl;

        #region Constructor
        public LoginService(IConfiguration config)
        {
            catalogServiceUrl = config["CatalogUrl"];
        }

        #endregion


        #region Login Service
        public async Task<string> Login(UserLogin credential)
      
        {
            using (HttpClient httpClient = new HttpClient())
            {

                string json = JsonConvert.SerializeObject(credential);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(catalogServiceUrl + "/Login/Authenticate", content);
                if (response.IsSuccessStatusCode)
{
                    var token = await response.Content.ReadAsStringAsync();
                    return token;
                }
                return null;
            }







        }
        #endregion
    }
}
