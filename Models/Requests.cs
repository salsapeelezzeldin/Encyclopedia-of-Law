using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Requests
    {
        public Requests()
        {
            Reviews = new HashSet<Reviews>();
        }

        public int RequestId { get; set; }
        public int LawyerId { get; set; }
        public int UserId { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Message { get; set; }
        public DateTime? AssignedDate { get; set; }
        public TimeSpan? AssignedTime { get; set; }
        public string RequestStatue { get; set; }

        public virtual Users Lawyer { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
