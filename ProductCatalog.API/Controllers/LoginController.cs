using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProductCatalog.API.DTO;
using ProductCatalog.API.Handler;
using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Role;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers
{

    [Route("[Controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        #region private variables
        private readonly CatalogDBContext _context;
        private readonly JWTSetting _jWTSetting;
        IOptions<JWTSetting> _options;
        #endregion

        #region Constructor
        public LoginController(CatalogDBContext context, IOptions<JWTSetting> options)
        {
            _context = context;
            _jWTSetting = options.Value;
            _options = options;
        }
        #endregion

        #region JWT token authentication for Login
        /// <summary>
        /// authentication
        /// </summary>
        /// <param name="credential"></param>
        /// <returns></returns>

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserLogin credential)
        {
            try { 
                Auth auth = new Auth(_context, _options);
                
                string token = auth.Authenticate(credential);
                if(token==null)
                {
                    return BadRequest();
                }
                return Ok(token);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
