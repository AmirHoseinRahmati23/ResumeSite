using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeSite.Web.Areas.Admin.Models
{
    public class PersonalInfoViewModel
    {
        [Display(Name = "عکس")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Image { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "نام و نام خانوادگی")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "سمت شغلی")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Work { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "شهر")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string City { get; set; }

        [Display(Name = "لینک اکانت اینستاگرام ")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Instagram { get; set; }

        [Display(Name = "لینک اکانت تلگرام")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Telegram { get; set; }

        [Display(Name = "لینک اکانت لینکدین")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Linkedin { get; set; }

        [Display(Name = "لینک اکانت توییتر")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Twitter { get; set; }

        [Display(Name = "فایل رزومه")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Resume { get; set; }

        public IFormFile ResumeFile { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
