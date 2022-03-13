using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeSite.Data.Entities
{
    public class Admin : Entity
    {
        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "نام کاربری")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Password { get; set; }

        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور دوم")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string SecoundPassword { get; set; }
    }
}
