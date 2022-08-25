using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encyclopedia_Of_Laws.Models;
using System.ComponentModel;


namespace Encyclopedia_Of_Laws.ViewModels
{
    public class AllChaptersViewModel
    {
        public int? IdCh { get; set; }
        public List<Chapter1> chapters { get; set; }

        [DisplayName("فصول2")]
        public Array chapter2 { get; set; }

        [DisplayName("فصول3")]
        public Array chapter3 { get; set; }
        public Chapter2 chapters2 { get; set; }

        public Chapter1 chapters1 { get; set; }

    }
}
