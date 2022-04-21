using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class LawyerInfo
    {
        public int LawyerId { get; set; }
        public string JopDescription { get; set; }
        public string Specialization { get; set; }
        public string Information { get; set; }
        public string OfficeNumber { get; set; }
        public string OfficeLocation { get; set; }

        public virtual Users Lawyer { get; set; }
    }
}
