using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cook_Book.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Cook_Book.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(CustomLoginModel loginModel)
        {
            if (LoginUser(loginModel.Email, loginModel.Password))
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, loginModel.Email)
            };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                //Just redirect to our index after logging in. 
                return RedirectToAction("Index", "Home");
            }

            return null; // View(); // logın vıew bulamıyordu.
        }

        private bool LoginUser(string email, string password)
        {
            if (email == "kubra.ay.150@gmail.com" && password == "kubra123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
