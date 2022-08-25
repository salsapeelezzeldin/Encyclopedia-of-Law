using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Law
    {
        public Law()
        {
            Partقسمكتاببابs = new HashSet<Partقسمكتابباب>();
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdLaw { get; set; }
        [DisplayName("أسم القانون")]
        public string اسمالقانون { get; set; }
        [DisplayName("أسم المصدر")]
        public string اسممصدره { get; set; }
        [DisplayName("جهة الإصدار ")]
        public string جهةالاصدار { get; set; }
        [DisplayName("رقم الوثيقه ")]
        public string رقمالوثيقه { get; set; }
        [DisplayName("تاريخ إصدار القانون ")]
        public string تاريخاصدارالقانون { get; set; }
        [DisplayName("جهة النشر ")]
        public string جهةالنشر { get; set; }
        [DisplayName("تاريخ النشر ")]
        public string تاريخالنشر { get; set; }

        public virtual ICollection<Partقسمكتابباب> Partقسمكتاببابs { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
