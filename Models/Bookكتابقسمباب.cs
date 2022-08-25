using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Bookكتابقسمباب
    {
        public Bookكتابقسمباب()
        {
            Sectionكتابقسمs = new HashSet<Sectionكتابقسم>();
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdB { get; set; }
        public int? IdS { get; set; }
        [DisplayName("رقم الكتاب")]
        public string رقمالكتاب { get; set; }
        [DisplayName("أسم الكتاب")]
        public string اسمالكتاب { get; set; }

        public virtual Partقسمكتابباب IdSNavigation { get; set; }
        public virtual ICollection<Sectionكتابقسم> Sectionكتابقسمs { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
