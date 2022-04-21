using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class فصل3
    {
        public فصل3()
        {
            مواد = new HashSet<مواد>();
        }

        public long IdCh3 { get; set; }
        public long? IdCh2 { get; set; }
        public string محتويالنقطه { get; set; }

        public virtual فصل2 IdCh2Navigation { get; set; }
        public virtual ICollection<مواد> مواد { get; set; }
    }
}
