using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessObject.Admin;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers.Admin
{
    
    [Route("[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogProductController : ControllerBase
    {

        private readonly ICatalogProductBO catalogProductBO;
        public CatalogProductController(ICatalogProductBO catalogProductBO)
        {
            this.catalogProductBO = catalogProductBO;
        }
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            return Ok(await catalogProductBO.GetAll());
        }
        /// <summary>
        /// get product data by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var catalogItem = await catalogProductBO.GetById(id);
            return catalogItem;
        }
        [HttpPost]
        public async Task<ActionResult<Product>> Add(Product product)
        {
            var item = await catalogProductBO.Add(product);
            return CreatedAtAction("GetAll", new { id = product.Id }, item);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await catalogProductBO.Delete(id);
            return NoContent();

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            

            await catalogProductBO.Update(product);
            return NoContent();

        }
    }
}
