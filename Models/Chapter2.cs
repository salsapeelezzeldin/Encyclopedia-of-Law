using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Encyclopedia_Of_Laws.Models
{
    public partial class Chapter2
    {
        public Chapter2()
        {
            Chapter3s = new HashSet<Chapter3>();
            Subjectsموادs = new HashSet<Subjectsمواد>();
        }

        public int IdCh2 { get; set; }
        public int? IdChapter { get; set; }
        [DisplayName("أسم النقطة")]
        public string اسمالنقطه { get; set; }

        public virtual Chapter1 IdChapterNavigation { get; set; }
        public virtual ICollection<Chapter3> Chapter3s { get; set; }
        public virtual ICollection<Subjectsمواد> Subjectsموادs { get; set; }
    }
}
