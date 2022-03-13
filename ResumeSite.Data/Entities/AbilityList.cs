using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeSite.Data.Entities
{
    public class AbilityList : Entity
    {
        [Required(ErrorMessage = "لظفا {0} را وارد کنید")]
        [Display(Name = "اسم لیست")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        public bool HaveImage { get; set; }

        public ICollection<Ability> Abilities { get; set; }
    }
}
