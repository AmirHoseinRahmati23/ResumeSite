using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeSite.Data;
using ResumeSite.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize]

    public class PersonalInfoController : Controller
    {
        private readonly ResumeSiteContext db;
        public PersonalInfoController(ResumeSiteContext dataBase)
        {
            db = dataBase;
        }
        public async Task<IActionResult> Index()
        {
            var info = await db.PersonalInfo.FirstAsync();
            return View(info);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var info = await db.PersonalInfo.FirstAsync();

            var model = new PersonalInfoViewModel()
            {
                Resume = info.ResumeFile,
                Name = info.Name,
                Linkedin = info.Linkedin,
                City = info.City,
                Telegram = info.Telegram,
                Twitter = info.Twitter,
                Instagram = info.Instagram,
                Image = info.Image,
                Work = info.Work
            };


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PersonalInfoViewModel model)
        {
            if (!ModelState.IsValid) return View();

            var info = await db.PersonalInfo.FirstAsync();
            #region Delete And Add Image

            var imageFilePath = Directory.GetCurrentDirectory() + "/wwwroot/" + "AdminImage/";
            var resumeFilePath = Directory.GetCurrentDirectory() + "/wwwroot/" + "ResumeFile/";
            if(model.ImageFile != null)
            {
                if (!string.IsNullOrEmpty(model.Image))
                {
                    System.IO.File.Delete(imageFilePath + model.Image);
                }

                using(var stream = new FileStream(imageFilePath + model.ImageFile.FileName , FileMode.Create , FileAccess.Write))
                {
                    await model.ImageFile.CopyToAsync(stream);
                }
                info.Image = model.ImageFile.FileName;

            }
            if(model.ResumeFile != null)
            {
                if (!string.IsNullOrEmpty(model.Resume))
                {
                    System.IO.File.Delete(resumeFilePath + model.Resume);
                }

                using (var stream = new FileStream(resumeFilePath + model.ResumeFile.FileName, FileMode.Create, FileAccess.Write))
                {
                    await model.ResumeFile.CopyToAsync(stream);
                }
                info.ResumeFile = model.ResumeFile.FileName;
            }
            #endregion

            #region Update Info

            info.Name = model.Name;
            info.Linkedin = model.Linkedin;
            info.City = model.City;
            info.Telegram = model.Telegram;
            info.Twitter = model.Twitter;
            info.Instagram = model.Instagram;
            info.Work = model.Work;

            #endregion

            await db.SaveChangesAsync();

            return RedirectToAction("Index", "PersonalInfo");
        }
    }
}
