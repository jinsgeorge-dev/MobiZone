using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class LookUpController : Controller
    {
        private readonly ILookUpService catalogService;
        private readonly INotyfService _notyf;
        IConfiguration Configuration { get; }
        public LookUpController(ILookUpService catalogService, INotyfService notyf, IConfiguration configuration)
        {
            this.catalogService = catalogService;
            this._notyf = notyf;
            this.Configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult> GetByParentId(int id)
        {

            var lookUpdata = (LookUpId)id;
            IEnumerable<LookUp> data = catalogService.GetItemsAsync().Result;
            var masterdata = data.Where(c => lookUpdata.Equals(c.ParentId));
            return View(masterdata);

        }
        [HttpGet]
        public async Task<IActionResult> LookUpData()
        {
            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> LookUpData(LookUp lookUp)
        {
            bool result = false;
            result = await catalogService.AddAsync(lookUp);
            if (result)
            {

                _notyf.Success(Configuration.GetSection("LookUp")["LookUpAdded"].ToString());
            }
            else
            {
                _notyf.Error(Configuration.GetSection("LookUp")["LookUpAddedError"].ToString());
            }
            ModelState.Clear();


            return View();

        }

    }
}
