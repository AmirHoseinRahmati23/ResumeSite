using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ResumeSite.Data;
using ResumeSite.Data.Entities;
using ResumeSite.Web.Database;
using ResumeSite.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ResumeSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDatabaseRepository _repository;
        private readonly ResumeSiteContext _db;
        public HomeController(ILogger<HomeController> logger, IDatabaseRepository repository, ResumeSiteContext db)
        {
            _logger = logger;
            _repository = repository;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _repository.GetHomePageInformationsAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(string userName, string email, string text)
        {
            var message = new Message()
            {
                Name = userName,
                Email = email,
                Text = text
            };

            await _db.AddAsync(message);
            await _db.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        [Route("/Login")]
        public IActionResult Login()
        {
            return RedirectToAction(nameof(Login), "Account");
        }

        
    }
}
