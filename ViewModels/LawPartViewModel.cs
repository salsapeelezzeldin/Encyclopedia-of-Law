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
    public class LawPartViewModel
    {
        public int? IdLaw { get; set; }

        [DisplayName("أقسام")]
        public Array أقسام { get; set; }

        public List<Law> laws { get; set; }

        public Partقسمكتابباب اقسام { get; set; } 
    }
}
