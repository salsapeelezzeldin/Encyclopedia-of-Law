using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Users
    {
        public Users()
        {
            RequestsLawyer = new HashSet<Requests>();
            RequestsUser = new HashSet<Requests>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int? RoleId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? PhoneNumber { get; set; }

        public virtual Roles Role { get; set; }
        public virtual ICollection<Requests> RequestsLawyer { get; set; }
        public virtual ICollection<Requests> RequestsUser { get; set; }
    }
}
