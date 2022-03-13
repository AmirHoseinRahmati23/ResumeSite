using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeSite.Data.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
