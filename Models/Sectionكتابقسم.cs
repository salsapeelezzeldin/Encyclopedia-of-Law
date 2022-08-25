using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Sectionكتابقسم
    {
        public Sectionكتابقسم()
        {
            Chapter1s = new HashSet<Chapter1>();
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdP { get; set; }
        public int? IdB { get; set; }
        [DisplayName("رقم الباب ")]
        public string رقمالباب { get; set; }
        [DisplayName("أسم الباب")]
        public string اسمالباب { get; set; }

        public virtual Bookكتابقسمباب IdBNavigation { get; set; }
        public virtual ICollection<Chapter1> Chapter1s { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
