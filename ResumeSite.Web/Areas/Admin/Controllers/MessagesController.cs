using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeSite.Data;
using ResumeSite.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize]
    public class MessagesController : Controller
    {
        private readonly ResumeSiteContext db;
        public MessagesController(ResumeSiteContext dataBase)
        {
            db = dataBase;
        }
        public async Task<IActionResult> Index()
        {
            var message = await db.Messages.AsNoTracking().ToListAsync();
            return View(message);
        }


        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var message = await db.Messages.FirstAsync(a => a.Id == id);

            await Task.Run(() =>
            {
                db.Remove(message);
            });

            await db.SaveChangesAsync();

            return RedirectToAction("Index", "Messages");
        }

        /*
        [HttpGet]
        public async Task<IActionResult> SendMessage(int id)
        {
            var message = await db.Messages.AsNoTracking().FirstAsync(m => m.Id == id);
            
            
            var model = new SendMessageViewModel()
            {
                Email = message.Email,
                UserName = message.Name,
                Text = message.Text,
                AnswerText = ""
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult SendMessage(SendMessageViewModel model)
        {
                SendEmail.SendEmail.Send(model.Email, "جواب پیام شما به من", model.AnswerText);
                ViewBag.Error = "";

            return RedirectToAction("Index", "Messages");
        }
        */

    }
}
