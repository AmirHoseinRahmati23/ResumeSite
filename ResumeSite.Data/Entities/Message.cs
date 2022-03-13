using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeSite.Data.Entities
{
    public class Message : Entity
    {
        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "نام کاربر")]
        [MaxLength(150, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "ایمیل ")]
        [MaxLength(150, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Email { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "متن پیام ")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Text { get; set; }
    }
}
