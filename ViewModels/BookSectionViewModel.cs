using System;
using Encyclopedia_Of_Laws.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Encyclopedia_Of_Laws.ViewModels
{
    public class BookSectionViewModel
    {
        public int? IdBook { get; set; }
        public List<Bookكتابقسمباب> books { get; set; }

        [DisplayName("أبواب")]
        public Array أبواب { get; set; }

        public Sectionكتابقسم ابواب { get; set; }


    }
}
