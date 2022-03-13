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
    public class AdminsController : Controller
    {
        private readonly ResumeSiteContext db;
        public AdminsController(ResumeSiteContext dataBase)
        {
            db = dataBase;
        }

        public async Task<IActionResult> Index()
        {
            var admins = await db.Admins.AsNoTracking().ToListAsync();
            return View(admins);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Data.Entities.Admin model)
        {
            if (!ModelState.IsValid) return View();

            await db.AddAsync(model);
            await db.SaveChangesAsync();

            return RedirectToAction("Index", "Admins");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var admin = await db.Admins.FindAsync(id);
            return View(admin);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Data.Entities.Admin model)
        {
            if (!ModelState.IsValid) return View();

            var admin = await db.Admins.FindAsync(model.Id);

            admin.UserName = model.UserName;
            admin.Password = model.Password;
            admin.SecoundPassword = model.SecoundPassword;

            await db.SaveChangesAsync();

            return RedirectToAction("Index", "Admins");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var admin = await db.Admins.FirstAsync(a => a.Id == id);

            await Task.Run(() =>
            {
                db.Remove(admin);
            });

            await db.SaveChangesAsync();

            return RedirectToAction("Index", "Admins");
        }
    }
}
