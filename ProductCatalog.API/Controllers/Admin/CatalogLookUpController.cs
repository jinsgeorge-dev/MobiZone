using Microsoft.AspNetCore.Mvc;
using ProductCatalog.BusinessObject;
using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ProductCatalog.API.Controllers
{
    [Authorize(Roles ="admin")]
    [Route("[controller]")]
    [ApiController]
    public class CatalogLookUpController : ControllerBase
    {
        

        private readonly ICatalogLookUpBO _catalogLookUpBO;

        public CatalogLookUpController(ICatalogLookUpBO catalogLookUpBO)
        {
            this._catalogLookUpBO = catalogLookUpBO;
        }
        #region Get LookUp item list
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LookUp>>> GetLookUpItems()
        {
            return Ok(await _catalogLookUpBO.GetLookUpItems());

        }

        #endregion


        #region post method for lookup items
        [HttpPost]
        public async Task<ActionResult<LookUp>> post(LookUp lookUp)
        {
                //lookUp.CreatedOnUTC = DateTime.UtcNow;
                var item = await _catalogLookUpBO.Add(lookUp);
                
                if (item.name == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction("GetLookUpItems", new { id = lookUp.Id }, item);
                }
           
        }

        #endregion



    }
}
