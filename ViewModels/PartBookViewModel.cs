using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encyclopedia_Of_Laws.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Encyclopedia_Of_Laws.ViewModels
{
    public class PartBookViewModel
    {
        public Bookكتابقسمباب book { get; set; }
        public List<Partقسمكتابباب> parts { get; set; }

        public Partقسمكتابباب part { get; set; }
        [DisplayName("كتب")]
        public Array كتب { get; set; }

        public int? IdS { get; set; }
    }
}
