using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Chapter3
    {
        public Chapter3()
        {
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdCh3 { get; set; }
        public int? IdCh2 { get; set; }
        [DisplayName("محتوى النقطة")]
        public string محتويالنقطه { get; set; }

        public virtual Chapter2 IdCh2Navigation { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
