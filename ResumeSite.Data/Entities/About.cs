using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeSite.Data.Entities
{
    public class About : Entity
    {
        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "درباره من")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string AboutMe { get; set; }


        [Display(Name = "ایمیل")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Email { get; set; }

        [Display(Name = "آدرس")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Address { get; set; }

        [Display(Name = "شماره موبایل")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }

        [Display(Name = "شماره تلفن")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Telephon { get; set; }
    }
}
