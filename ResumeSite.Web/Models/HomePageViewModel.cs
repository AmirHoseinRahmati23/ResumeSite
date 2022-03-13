using ResumeSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Models
{
    public class HomePageViewModel
    {
        public About About { get; set; }
        public List<AbilityList> AbilityLists { get; set; }

    }
}
