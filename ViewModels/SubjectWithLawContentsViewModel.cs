using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encyclopedia_Of_Laws.Models;

namespace Encyclopedia_Of_Laws.ViewModels
{
    public class SubjectWithLawContentsViewModel
    {
        public List<Law> law_list { get; set; }

        public List<Partقسمكتابباب> part_list { get; set; }

        public List<Bookكتابقسمباب> book_list { get; set; }

        public List<Sectionكتابقسم> section_list { get; set; }

        public List<Chapter1> chapter1_list { get; set; }

        public List<Chapter2> chapter2_list { get; set; }

        public List<Chapter3> chapter3_list { get; set; }

        public Subjectsمواد subject { get; set; }

    }
}
