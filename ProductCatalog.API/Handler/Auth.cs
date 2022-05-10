using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProductCatalog.API.DTO;
using ProductCatalog.Domain.DataBase;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.API.Handler
{
    public class Auth
    {
        #region private variables
        private readonly CatalogDBContext _context;
        private readonly JWTSetting _jWTSetting;
        #endregion

        #region Constructor
        public Auth(CatalogDBContext context, IOptions<JWTSetting> options)
        {
            _context = context;
            _jWTSetting = options.Value;
        }
        #endregion

        #region JWT token authentication for Login  
        /// <summary>
        /// used to crate JWT token 
        /// </summary>
        /// <param name="credential">used to handle username and password</param>
        /// <returns>it return JWT token</returns>
       
        public string Authenticate([FromBody] UserLogin credential)
        {
            var user = _context.User.Include(o => o.Role).FirstOrDefault(o => o.UserName == credential.UserName && o.Password == credential.password);


            if (user == null)
            {
                return null;
                //throw new Exception("Unauthorized");
            }              
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_jWTSetting.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.Role, user.Role.UserRole)
                    }
                ),
                Expires = DateTime.Now.AddSeconds(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            string finalToken = tokenhandler.WriteToken(token);
            return finalToken;
        }
        #endregion
    }
}
