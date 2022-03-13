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
    public class AbilityListController : Controller
    {
        private readonly ResumeSiteContext db;
        public AbilityListController(ResumeSiteContext dataBase)
        {
            db = dataBase;
        }
        public async Task<IActionResult> Index()
        {
            var lists = await db.AbilityLists.AsNoTracking().ToListAsync();
            return View(lists);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AbilityList model)
        {
            if (!ModelState.IsValid) return View();

            await db.AddAsync(model);
            await db.SaveChangesAsync();

            return RedirectToAction("Index", "AbilityList");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var list = await db.AbilityLists.FindAsync(id);
            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AbilityList model)
        {
            if (!ModelState.IsValid) return View();

            var list = await db.AbilityLists.FindAsync(model.Id);

            list.Name = model.Name;

            await db.SaveChangesAsync();

            return RedirectToAction("Index", "AbilityList");
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var list = await db.AbilityLists.Include(a => a.Abilities).FirstAsync(a => a.Id == id);

            await Task.Run(() =>
           {
               db.Remove(list);
           });

            if(list.Abilities != null)
            {
                foreach(var ability in list.Abilities)
                {
                    await Task.Run(() =>
                    {
                        db.Remove(ability);
                    });
                }
            }
            await db.SaveChangesAsync();

            return RedirectToAction("Index", "AbilityList");
        }

        [HttpGet]
        public async Task<IActionResult> AbilityIndex(int id)
        {
            var abilities = await db.Abilities.Where(a => a.ListId == id).ToListAsync();
            ViewBag.ListId = id;
            return View(abilities);
        }

        [HttpGet]
        public IActionResult AddAbility(int id)
        {
            var model = new Ability()
            {
                ListId = id
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddAbility(Ability ability)
        {
            if (!ModelState.IsValid) return View();


            await db.AddAsync(ability);
            await db.SaveChangesAsync();


            return RedirectToAction("AbilityIndex", "AbilityList" , new { id = ability.ListId });
        }

        [HttpGet]
        public async Task<IActionResult> EditAbility(int id)
        {
            var ability = await db.Abilities.FindAsync(id);
            return View(ability);
        }
        [HttpPost]
        public async Task<IActionResult> EditAbility(Ability model)
        {
            if (!ModelState.IsValid) return View();

            var ability = await db.Abilities.FindAsync(model.Id);

            ability.Text = model.Text;

            await db.SaveChangesAsync();

            return RedirectToAction("AbilityIndex", "AbilityList", new { id = ability.ListId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAbility(int id)
        {
            var ability = await db.Abilities.FindAsync(id);

            var listId = ability.ListId;

            await Task.Run(() =>
            {
                db.Remove(ability);
            });


            await db.SaveChangesAsync();

            return RedirectToAction("Index", "AbilityIndex" , new { id = listId });
        }
    }
}
