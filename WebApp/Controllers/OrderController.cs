using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly Services.IOrderService catalogService;

        public OrderController(IOrderService catalogService)
        {
            this.catalogService = catalogService;
        }
        public async Task<IActionResult> Index()
        {
            var items = await catalogService.GetCatalogOrder();
            return View(items);
        }
    }
}
