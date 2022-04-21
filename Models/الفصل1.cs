using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class الفصل1
    {
        public الفصل1()
        {
            فصل2 = new HashSet<فصل2>();
            مواد = new HashSet<مواد>();
        }

        public long IdChapter { get; set; }
        public long? IdP { get; set; }
        public string رقمالفصل { get; set; }
        public string اسمالفصل { get; set; }

        public virtual بابكتابقسم IdPNavigation { get; set; }
        public virtual ICollection<فصل2> فصل2 { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
