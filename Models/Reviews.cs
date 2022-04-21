using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Reviews
    {
        public int ReviewId { get; set; }
        public int ReqId { get; set; }
        public int Rate { get; set; }
        public string Review { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual Requests Req { get; set; }
    }
}
