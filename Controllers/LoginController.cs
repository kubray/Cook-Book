using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Cook_Book.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
            if (Checkpassword(loginModel.Email, loginModel.Password))
            {
                /*
                var claims = new List<Claim>
                {
                 new Claim(ClaimTypes.Email, loginModel.Email)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                */

                HttpContext.Session.SetString("email", loginModel.Email);

                //log out etmek için
                //HttpContext.Session.SetString("email",null);

                //Just redirect to our index after logging in. 
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return null; // View(); // logın vıew bulamıyordu.
            }
        }

        [HttpGet]
        public IActionResult  LogOut()
        {
           
            HttpContext.Session.SetString("email","");

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");

        }

        private bool Checkpassword(string email, string password)
        {
            if (email == "kubra.ay.150@gmail.com" && password == "kubra123")        //TODO: Make this check dynamic. 
            {
                
                //return View("Success");
                return true;
            }
            else
            {
                return false;
                //ViewBag.error = "Invalid Account";
                //return View("Index");
            }

        }


    }
}
