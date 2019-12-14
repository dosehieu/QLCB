using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    public class AccountController : Controller
    {
        private bool IsAuthenticated(string username, string password)
        {
            return (username == "hieu" && password == "123");
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!IsAuthenticated(model.Username, model.Password))
                return Redirect(model.RequestPath ?? "/");

            // create claims
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "Cookie authentication demo"),
                new Claim(ClaimTypes.Email, model.Username)
            };

            // create identity
            ClaimsIdentity identity = new ClaimsIdentity(claims, "cookie");

            // create principal
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            // sign-in
            await HttpContext.SignInAsync(
            scheme: "DemoSecurityScheme",
            principal: principal,
            properties: new AuthenticationProperties
            {
                //IsPersistent = true, // for 'remember me' feature
                //ExpiresUtc = DateTime.UtcNow.AddMinutes(1)
            });
            return RedirectToAction("Index", "Home");
            
        }
        public async Task<IActionResult> Logout(string requestPath)
        {
            await HttpContext.SignOutAsync(
                    scheme: "DemoSecurityScheme");

            return RedirectToAction("Index");
        }
    }
}