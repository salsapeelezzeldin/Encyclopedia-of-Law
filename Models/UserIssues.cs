using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class UserIssues
    {
        public int IssueId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime? IssueDate { get; set; }
        public string RequestStatue { get; set; }
    }
}
