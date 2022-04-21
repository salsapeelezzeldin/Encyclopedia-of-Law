using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class بابكتابقسم
    {
        public بابكتابقسم()
        {
            الفصل1 = new HashSet<الفصل1>();
            مواد = new HashSet<مواد>();
        }

        public long IdP { get; set; }
        public long? IdB { get; set; }
        public string رقمالباب { get; set; }
        public string اسمالباب { get; set; }

        public virtual كتابقسمباب IdBNavigation { get; set; }
        public virtual ICollection<الفصل1> الفصل1 { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
