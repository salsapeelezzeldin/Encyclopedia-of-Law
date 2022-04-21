using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class مواد
    {
        public long IdSubjects { get; set; }
        public long? IdChapter { get; set; }
        public long? IdCh2 { get; set; }
        public long? IdCh3 { get; set; }
        public string رقمالماده { get; set; }
        public string محتوىالماده { get; set; }
        public string حالهالماده { get; set; }
        public string التعديلالسابقللماده { get; set; }
        public string سنهالتعديلالسابق { get; set; }
        public long? IdLaw { get; set; }
        public long? IdSقسم { get; set; }
        public long? IdB { get; set; }
        public long? IdP { get; set; }

        public virtual كتابقسمباب IdBNavigation { get; set; }
        public virtual فصل2 IdCh2Navigation { get; set; }
        public virtual فصل3 IdCh3Navigation { get; set; }
        public virtual الفصل1 IdChapterNavigation { get; set; }
        public virtual القانون IdLawNavigation { get; set; }
        public virtual بابكتابقسم IdPNavigation { get; set; }
        public virtual قسمكتابباب IdSقسمNavigation { get; set; }
    }
}
