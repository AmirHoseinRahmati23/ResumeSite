using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeSite.Data;
using ResumeSite.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ResumeSite.Web.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly ResumeSiteContext _db;
        public AccountController(ResumeSiteContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            var user = await _db.Admins.SingleOrDefaultAsync(a => a.UserName == model.UserName &&
                                                        a.Password == model.Password &&
                                                        a.SecoundPassword == model.SecoundPassword);

            if (user == null)
            {
                return NotFound();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.UserName),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var identity = new ClaimsIdentity(claims
                                              , CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties()
            {
                IsPersistent = model.RememberMe
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                                            , principal, properties);

            return Redirect("/Admin/Home/Index");
        }


        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/");
        }
    }
}
