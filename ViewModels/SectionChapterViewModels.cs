using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encyclopedia_Of_Laws.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Encyclopedia_Of_Laws.ViewModels
{
    public class SectionChapterViewModels
    {
        [Key]

        public int id;
        public int? IdSection { get; set; }

        [DisplayName("فصول")]
        public Array chapters { get; set; }

        public List<Sectionكتابقسم> sections { get; set; }

        public Chapter1 chapter { get; set; }
        public Chapter2 chapters2 { get; set; }
        public List<Chapter2> chapter2 { get; set; }
        public Chapter3 chapters3 { get; set; }
        public List<Chapter3> chapter3 { get; set; }
        public string[] Chapter2_names { get; set; }

        public string[] Chapter3_names { get; set; }
        public int? IdChapter1 { get; set; }
    }
}
