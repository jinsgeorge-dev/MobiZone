using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Order;
using ProductCatalog.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ProductCatalog.API.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogOrderController : ControllerBase
    {
        private readonly CatalogDBContext _context;
        private readonly CatalogOrderBO catalogOrderBO;


        public CatalogOrderController(CatalogDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogOrder>>> GetCatalogOrder()
        {
            return await _context.CatalogOrder.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<CatalogOrder>> PostCatalogOrder(CatalogOrder catalogOrder)
        {
            var item = await catalogOrderBO.Add(catalogOrder);
            return CreatedAtAction("GetCatalogOrder", new { id = catalogOrder.product_id }, item);
        }

       

    }
}
