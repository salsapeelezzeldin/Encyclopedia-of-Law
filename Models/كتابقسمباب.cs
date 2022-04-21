using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class كتابقسمباب
    {
        public كتابقسمباب()
        {
            بابكتابقسم = new HashSet<بابكتابقسم>();
            مواد = new HashSet<مواد>();
        }

        public long IdB { get; set; }
        public long? IdS { get; set; }
        public string رقمالكتاب { get; set; }
        public string اسمالكتاب { get; set; }

        public virtual قسمكتابباب IdSNavigation { get; set; }
        public virtual ICollection<بابكتابقسم> بابكتابقسم { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
