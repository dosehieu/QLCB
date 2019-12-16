using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using QLCBCore.Models;
using QLCBCore.ViewModels;

namespace QLCBCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly QLCBDbContext _context;
        public LoginController(QLCBDbContext context)
        {
            _context = context;
        }
        private bool IsAuthenticated(string username, string password)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string PasswordHash = sb.ToString();
            return _context.NguoiDungs.SingleOrDefault(n => n.UserName == username && n.Password == PasswordHash) != null;
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