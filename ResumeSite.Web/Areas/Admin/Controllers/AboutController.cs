using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeSite.Data;
using ResumeSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize]
    public class AboutController : Controller
    {
        private readonly ResumeSiteContext db;
        public AboutController(ResumeSiteContext dataBase)
        {
            db = dataBase;
        }

        public async Task<IActionResult> Index()
        {
            var about = await db.About.FirstAsync();
            return View(about);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var about = await db.About.FirstAsync();

            var model = new About()
            {
                AboutMe = about.AboutMe,
                Address = about.Address,
                Email = about.Email,
                Mobile = about.Mobile,
                Telephon = about.Telephon,
            };


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About model)
        {
            if (!ModelState.IsValid) return View();

            var about = await db.About.FirstAsync();

            #region Update Info

            about.AboutMe = model.AboutMe;
            about.Address = model.Address;
            about.Mobile = model.Mobile;
            about.Telephon = model.Telephon;
            about.Email = model.Email;

            #endregion

            await db.SaveChangesAsync();

            return RedirectToAction("Index", "About");
        }
    }
}
