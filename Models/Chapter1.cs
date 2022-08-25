using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Chapter1
    {
        public Chapter1()
        {
            Chapter2s = new HashSet<Chapter2>();
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdChapter { get; set; }
        public int? IdP { get; set; }
        [DisplayName("رقم الفصل")]
        public string رقمالفصل { get; set; }
        [DisplayName("أسم الفصل")]
        public string اسمالفصل { get; set; }

        public virtual Sectionكتابقسم IdPNavigation { get; set; }
        public virtual ICollection<Chapter2> Chapter2s { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
