using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;
using System.Net.Http;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService catalogService;

        public ProductController(IProductService catalogService)
        {
            this.catalogService = catalogService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        
        {
            var items = await catalogService.GetProductItemsAsync();
            return View(items);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var items = await catalogService.GetProductItemsByIdAsync(id);
            return View(items);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var items = await catalogService.AddProductItemsAsync(product);
            return View(items);
        }
    }
}

