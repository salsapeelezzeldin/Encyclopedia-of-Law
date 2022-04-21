using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class قسمكتابباب
    {
        public قسمكتابباب()
        {
            كتابقسمباب = new HashSet<كتابقسمباب>();
            مواد = new HashSet<مواد>();
        }

        public long IdS { get; set; }
        public long? IdLaw { get; set; }
        public string رقمالقسم { get; set; }
        public string اسمالقسم { get; set; }

        public virtual القانون IdLawNavigation { get; set; }
        public virtual ICollection<كتابقسمباب> كتابقسمباب { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
