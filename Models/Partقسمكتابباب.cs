using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Partقسمكتابباب
    {
        public Partقسمكتابباب()
        {
            Bookكتابقسمبابs = new HashSet<Bookكتابقسمباب>();
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdS { get; set; }
        public int? IdLaw { get; set; }
        [DisplayName("رقم القسم ")]
        public string رقمالقسم { get; set; }
        [DisplayName("أسم القسم")]
        public string اسمالقسم { get; set; }

        public virtual Law IdLawNavigation { get; set; }
        public virtual ICollection<Bookكتابقسمباب> Bookكتابقسمبابs { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
