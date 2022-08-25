using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Encyclopedia_Of_Laws.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            RequestLawyers = new HashSet<Request>();
            RequestUsers = new HashSet<Request>();
        }


        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required, MaxLength(50)]
        public string Gender { get; set; }

        public string ProfilePicture { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
        public virtual LawyerInfo LawyerInfo { get; set; }
        public virtual ICollection<Request> RequestLawyers { get; set; }
        public virtual ICollection<Request> RequestUsers { get; set; }


    }
}
