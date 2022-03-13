using Microsoft.EntityFrameworkCore;
using ResumeSite.Data;
using ResumeSite.Data.Entities;
using ResumeSite.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Database
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private readonly ResumeSiteContext db;
        public DatabaseRepository(ResumeSiteContext context)
        {
            db = context;
        }

        public async Task<HomePageViewModel> GetHomePageInformationsAsync()
        {
            var info = new HomePageViewModel()
            {
                AbilityLists = await db.AbilityLists.Include(l => l.Abilities).AsNoTracking().ToListAsync(),
                About = await db.About.FirstAsync()
            };

            return info;
        }

        public async Task<PersonalInfo> GetPersonalInfoAsync()
        {
            return await db.PersonalInfo.FirstAsync();
        }
    }
}
