using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Subjectsمواد
    {
        public int IdSubjects { get; set; }
        public int? IdChapter { get; set; }
        public int? IdCh2 { get; set; }
        public int? IdCh3 { get; set; }
        [DisplayName("رقم الماده ")]
        public string رقمالماده { get; set; }
        [DisplayName("محتوى الحالي ")]
        public string محتوىالماده { get; set; }
        [DisplayName("حالة الماده ")]
        public string حالهالماده { get; set; }
        [DisplayName("المحتوى السابق  ")]
        public string التعديلالسابقللماده { get; set; }
        [DisplayName("سنة التعديل السابق ")]
        public string سنهالتعديلالسابق { get; set; }
        public int? IdLaw { get; set; }
        public int? IdSقسم { get; set; }
        public int? IdB { get; set; }
        public int? IdP { get; set; }

        public virtual Bookكتابقسمباب IdBNavigation { get; set; }
        public virtual Chapter2 IdCh2Navigation { get; set; }
        public virtual Chapter3 IdCh3Navigation { get; set; }
        public virtual Chapter1 IdChapterNavigation { get; set; }
        public virtual Law IdLawNavigation { get; set; }
        public virtual Sectionكتابقسم IdPNavigation { get; set; }
        public virtual Partقسمكتابباب IdSقسمNavigation { get; set; }
    }
}
