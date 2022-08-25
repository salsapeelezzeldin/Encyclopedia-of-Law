using Encyclopedia_Of_Laws.Data;
using Encyclopedia_Of_Laws.Models;
using Encyclopedia_Of_Laws.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using Encyclopedia_Of_Laws.Views.Subject.pager;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rotativa;
using Rotativa.AspNetCore;
using ViewAsPdf = Rotativa.AspNetCore.ViewAsPdf;
using System.IO;

using Encyclopedia_Of_Laws.ViewModels;


namespace Encyclopedia_Of_Laws.Controllers
{
    public class SubjectController : Controller
    {
        public readonly EncyclopediaOfLawsContext _context;
        public SubjectController(EncyclopediaOfLawsContext context)
        {
            _context = context;
        }


        //GetPageSizes method
        private List<SelectListItem> GetPageSizes(int selectPageSize = 10)
        {
            var pageSizes = new List<SelectListItem>();
            if (selectPageSize == 5)
                pageSizes.Add(new SelectListItem("5", "5", true));
            else
                pageSizes.Add(new SelectListItem("5", "5"));
            for (int lp = 10; lp <= 100; lp += 10)
            {
                if (lp == selectPageSize)
                { pageSizes.Add(new SelectListItem(lp.ToString(), lp.ToString(), true)); }
                else
                    pageSizes.Add(new SelectListItem(lp.ToString(), lp.ToString()));

            }
            return pageSizes;

        }

        // GET: SubjectsController1
        public ActionResult Index(string SearchText = "", int pg = 1, int pageSize = 10)
        {
            List<Subjectsمواد> subject;


            if (SearchText != "" && SearchText != null)
            {
                subject = _context.Subjectsموادs
                    .Where(p => p.محتوىالماده.Contains(SearchText)
                    || p.حالهالماده.Contains(SearchText)
                    || p.التعديلالسابقللماده.Contains(SearchText)
                    || p.سنهالتعديلالسابق.Contains(SearchText)
                     || p.رقمالماده.Contains(SearchText)).ToList();
            }

            else
                subject = _context.Subjectsموادs.ToList();

            ///////////////////
            //pager
            //10 ده رقم المواد الي بتظهر في الصفحه الواحده 
            // const int pageSize = 10;
            if (pg < 1)
                pg = 1;

            int recsCount = subject.Count();

            var pager = new SubjectPager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;



            var data = subject.Skip(recSkip).Take(pager.SPageSize).ToList();
            this.ViewBag.SubjectPager = pager;

            this.ViewBag.PageSizes = GetPageSizes(pageSize);

            //return View(data);

            return View(data);
        }

        // GET: SubjectsController1/Details/5
        public ActionResult Details(int id)
        {
            Subjectsمواد ماده = _context.Subjectsموادs.Where(p => p.IdSubjects == id).FirstOrDefault();
            return View(ماده);
            //بترجع التفاصيل كلها ملف
            // return new ViewAsPdf(ماده);
        }


        public ActionResult TheLasUpdate(int id)
        {

            Subjectsمواد ماده = _context.Subjectsموادs.Where(p => p.IdSubjects == id).FirstOrDefault();
            return View(ماده);
        }


        //public ActionResult PrintAll(int id)
        //{
        //    //دي بترجع ملف فاضي من الكلام
        //    //var q = new ViewAsPdf("Details");
        //    //return q;

        //    //مواد ماده = _context.مواد.Where(p => p.IdSubjects == id).FirstOrDefault();
        //    //return new ViewAsPdf(ماده);


        //    ////دي بترجع ملف فاضي من الكلام
        //    //return new ViewAsPdf("Details");
        //}

        //******************************** بدايه التحميل شغال الحمد لله ************************************
        // single file 
        public IActionResult DownloadFile()
        {
            var memory = DownloadSinghFile("civil law.pdf", "wwwroot\\file");
            return File(memory.ToArray(), "application / pdf", "civil law.pdf");
        }



        private MemoryStream DownloadSinghFile(string filename, string uploadPath)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), uploadPath, filename);
            var memory = new MemoryStream();
            if (System.IO.File.Exists(path))
            {
                var net = new System.Net.WebClient();
                var data = net.DownloadData(path);
                var content = new System.IO.MemoryStream(data);
                memory = content;
            }
            memory.Position = 0;
            return memory;
        }

        // ******************************** نهاية التحميل شغال الحمد لله **************************

        //*************************  الفهرس *****************************
        // القسم part
        public Array GETPart()
        {
            Array parts = _context.Partقسمكتاببابs.Select(p => new Partقسمكتابباب { رقمالقسم = p.رقمالقسم, اسمالقسم = p.اسمالقسم, IdLaw = p.IdLaw, IdS = p.IdS }).ToArray();
            return parts;
        }

        // كتاب book
        public Array GetBook()
        {
            Array books = _context.Bookكتابقسمبابs.Select(p => new Bookكتابقسمباب { رقمالكتاب = p.رقمالكتاب, اسمالكتاب = p.اسمالكتاب, IdS = p.IdS, IdB = p.IdB }).ToArray();
            return books;
        }

        //باب section 
        public Array GetSection()
        {
            Array sections = _context.Sectionكتابقسمs.Select(p => new Sectionكتابقسم { رقمالباب = p.رقمالباب, اسمالباب = p.اسمالباب, IdB = p.IdB, IdP = p.IdP }).ToArray();
            return sections;
        }

        // فصل 
        public Array GetChapter()
        {
            Array chapters = _context.Chapter1s.Select(p => new Chapter1 { رقمالفصل = p.رقمالفصل, اسمالفصل = p.اسمالفصل, IdP = p.IdP, IdChapter = p.IdChapter }).ToArray();
            return chapters
                ;
        }

        public Array Getchapter2()
        {
            Array chapter2 = _context.Chapter2s.Select(p => new Chapter2 { اسمالنقطه = p.اسمالنقطه, IdChapter = p.IdChapter, IdCh2 = p.IdCh2 }).ToArray();
            return chapter2;
        }


        public Array Getchapter3()
        {
            Array chapter3 = _context.Chapter3s.Select(p => new Chapter3 { محتويالنقطه = p.محتويالنقطه, IdCh2 = p.IdCh2, IdCh3 = p.IdCh3 }).ToArray();
            return chapter3;
        }
        public Array GetSubject()
        {
            Array subjects = _context.Subjectsموادs.Select(p => new Subjectsمواد { رقمالماده = p.رقمالماده, IdChapter = p.IdChapter, IdCh2 = p.IdCh2, IdCh3 = p.IdCh3, IdSubjects = p.IdSubjects }).ToArray();
            return subjects;
        }
        private ActionResult PartDetails(int id)
        {
            Partقسمكتابباب part = _context.Partقسمكتاببابs.Where(p => p.IdS == id).FirstOrDefault();
            return View(part);

        }

        public ActionResult ChapterPage()
        {
            List<Law> laws = _context.Laws.ToList();


            var model = new LawContenetViewModel
            {
                laws = laws,
                parts = GETPart(),
                books = GetBook(),
                sections = GetSection(),
                chapters = GetChapter(),
                chapter2 = Getchapter2(),
                chapter3 = Getchapter3(),
                subjects = GetSubject()

            };
            return View(model);
        }
     



        private void msCopy_click(object sender, EventArgs e)
        {
            // txtMessage.Copy();
            //  Clipboard.SetTex(txtMessage.SelectedText);
            //documentEditor.selection.copy();
        }

        // GET: SubjectsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectsController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectsController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectsController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
