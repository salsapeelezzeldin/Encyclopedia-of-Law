using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class القانون
    {
        public القانون()
        {
            قسمكتابباب = new HashSet<قسمكتابباب>();
            مواد = new HashSet<مواد>();
        }

        public long IdLaw { get; set; }
        public string اسمالقانون { get; set; }
        public string اسممصدره { get; set; }
        public string جهةالاصدار { get; set; }
        public string رقمالوثيقه { get; set; }
        public string تاريخاصدارالقانون { get; set; }
        public string جهةالنشر { get; set; }
        public string تاريخالنشر { get; set; }

        public virtual ICollection<قسمكتابباب> قسمكتابباب { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
