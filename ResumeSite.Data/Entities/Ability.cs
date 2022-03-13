using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeSite.Data.Entities
{
    public class Ability : Entity
    {
        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "متن دلخواه ")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Text { get; set; }

        [Display(Name = "نام عکس")]
        [MaxLength(200,ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string ImageName { get; set; }

        public int ListId { get; set; }

        public AbilityList List { get; set; }
    }
}
