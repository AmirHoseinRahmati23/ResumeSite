using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Areas.Admin.Models
{
    public class SendMessageViewModel
    {
        public string Email { get; set; }
        public string AnswerText { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }

    }
}
