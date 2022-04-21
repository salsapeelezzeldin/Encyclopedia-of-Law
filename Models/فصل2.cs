using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class فصل2
    {
        public فصل2()
        {
            فصل3 = new HashSet<فصل3>();
            مواد = new HashSet<مواد>();
        }

        public long IdCh2 { get; set; }
        public long? IdChapter { get; set; }
        public string اسمالنقطه { get; set; }

        public virtual الفصل1 IdChapterNavigation { get; set; }
        public virtual ICollection<فصل3> فصل3 { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
