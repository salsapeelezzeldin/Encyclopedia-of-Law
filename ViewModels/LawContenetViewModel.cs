using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encyclopedia_Of_Laws.Models;

namespace Encyclopedia_Of_Laws.ViewModels
{
    public class LawContenetViewModel
    {
        public int? IdLaw { get; set; }

        //public Array اقسام { get; set; }


        //public قسمكتابباب اقسامم { get; set; }



        //public List<الفصل1> chapters { get; set; }
        public List<Law> laws { get; set; }

        public Array parts { get; set; }
        public Array books { get; set; }
        public Array sections { get; set; }
        public Array chapters { get; set; }
        public Array chapter2 { get; set; }
        public Array chapter3 { get; set; }
        public Array subjects { get; set; }

    }
}
