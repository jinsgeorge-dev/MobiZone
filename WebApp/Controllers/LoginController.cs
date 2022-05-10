using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.Extensions.Configuration;
using WebApp.Services;
using ProductCatalog.API.DTO;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginService _loginService;
        IConfiguration _configuration { get; }
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(ILoginService loginService,  IConfiguration configuration)
        {
            this._loginService = loginService;
            this._configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login(string loginUrl)
        {
           // var model = new UserLogin { ReturnUrl = returnUrl };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin credential)
        {
           var token = await _loginService.Login(credential);
            if (token!=null)
            {
                var claims = new List<Claim>();

                claims.Add(new Claim("password", credential.password));
                //claims.Add(new Claim(ClaimTypes.NameIdentifier, credential.UserName));
                claims.Add(new Claim(ClaimTypes.Name, credential.UserName));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            TempData["Error"] = "Invalid UserName or Password";
             return View("Login");


            //if (ModelState.IsValid)
            //{
            //    var result = await _signInManager.PasswordSignInAsync(credential.UserName,
            //       credential.password, credential.RememberMe, false);

            //    if (result.Succeeded)
            //    {
            //        if (!string.IsNullOrEmpty(credential.ReturnUrl) && Url.IsLocalUrl(credential.ReturnUrl))
            //        {
            //            return Redirect(credential.ReturnUrl);
            //        }
            //        else
            //        {
            //            return RedirectToAction("Index", "Home");
            //        }
            //    }
            //}
            //ModelState.AddModelError("", "Invalid login attempt");
            //return View(model);
        }


    }
}
