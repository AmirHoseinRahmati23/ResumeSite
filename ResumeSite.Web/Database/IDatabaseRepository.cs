using ResumeSite.Data.Entities;
using ResumeSite.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Database
{
    public interface IDatabaseRepository
    {
        public Task<PersonalInfo> GetPersonalInfoAsync();
        public Task<HomePageViewModel> GetHomePageInformationsAsync();
    }
}
