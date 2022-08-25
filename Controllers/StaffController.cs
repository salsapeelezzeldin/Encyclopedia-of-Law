using Encyclopedia_Of_Laws.Data;
using Encyclopedia_Of_Laws.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encyclopedia_Of_Laws.Views.Shared.Components.SearchBar1;
using Encyclopedia_Of_Laws.ViewModels;
using System.Collections;

namespace Encyclopedia_Of_Laws_Test7_.Controllers
{
    public class StaffController : Controller
    {
        public readonly EncyclopediaOfLawsContext _context;
        public StaffController(EncyclopediaOfLawsContext context)
        {
            _context = context;
        }
        public int SearchPager(IEnumerable<object> obj, int pg, string action, string controller, string searchtext)
        {
            const int pagesize = 77;
            if (pg < 1)
                pg = 1;
            int recsCount = obj.Count();
            var SearchPager = new SPager(recsCount, pg, pagesize) { Action = action, Controller = controller, SearchText = searchtext };
            ViewBag.SearchPager = SearchPager;
            return pagesize;
        }
        //-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.

        //Method to return an array of parts
        public Array GetParts()
        {
            Array parts = _context.Partقسمكتاببابs
                .Select(p => new Partقسمكتابباب { اسمالقسم = p.اسمالقسم , IdLaw = p.IdLaw , IdS = p.IdS}).ToArray();
            return parts;
        }

        //ActionMethod To return a viewmodel that contains the properties of Law and parts to combine them togther
        public ActionResult LawPage(string SearchText = "", int pg = 1)
        {
            List<Law> laws = _context.Laws.ToList();
            if (SearchText != "" && SearchText != null)
            {
                laws = _context.Laws.Where(p => p.اسمالقانون
                .Contains(SearchText)).ToList();
            }
            int i = SearchPager(laws , pg , "LawPage" , "Staff" , SearchText);
            int recSkip = (pg - 1) * i;
            laws = laws.Skip(recSkip).Take(i).ToList();
            var model = new LawPartViewModel
            {
                laws = laws,
                أقسام = GetParts()
            };

            return View(model);
        }
        //Actions that are performed in the Law_part viewModel
        [HttpGet]
        public ActionResult Create_Law()
        {
            Law law = new Law();
            return View(law);
        }

        [HttpPost]
        public IActionResult Create_Law(Law laws)
        {
            _context.Attach(laws);
            _context.Entry(laws).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("LawPage");
        }
        [HttpGet]
        public IActionResult Edit_Law(long Id)
        {
            Law laws = _context.Laws.Where(p => p.IdLaw == Id).FirstOrDefault();
            return View(laws);
        }
        [HttpPost]
        public IActionResult Edit_Law(Law laws)
        {
            _context.Attach(laws);
            _context.Entry(laws).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("LawPage");
        }
        public IActionResult Law_Details(long Id)
        {
            Law laws = _context.Laws.Where(p => p.IdLaw == Id).FirstOrDefault();
            return View(laws);
        }
        //-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.

        //Method to return an array of parts
        public Array GetBooks()
        {
            Array books = _context.Bookكتابقسمبابs
                .Select(p => new Bookكتابقسمباب { اسمالكتاب = p.اسمالكتاب, IdS = p.IdS , IdB = p.IdB }).ToArray();
            return books;
        }

        //ActionMethod To return a viewmodel that contains the properties of Law and parts to combine them togther
        public ActionResult PartPage(string SearchText = "", int pg = 1)
        {
            List<Partقسمكتابباب> parts = _context.Partقسمكتاببابs.ToList();
            if (SearchText != "" && SearchText != null)
            {
                parts = _context.Partقسمكتاببابs.Where(p => p.اسمالقسم
                .Contains(SearchText)).ToList();
            }
            int i = SearchPager(parts, pg, "PartPage", "Staff", SearchText);
            int recSkip = (pg - 1) * i;
            parts = parts.Skip(recSkip).Take(i).ToList();
            var model = new PartBookViewModel
            {
                parts = parts,
                كتب = GetBooks()
            };

            return View(model);
        }
        //Actions that are performed in the Law_part viewModel
        [HttpGet]
        public ActionResult Create_Part()
        {
            Partقسمكتابباب law = new Partقسمكتابباب();
            List<Law> parts = _context.Laws.ToList();
            var model = new LawPartViewModel
            {
                اقسام = law,
                laws = parts,
                IdLaw = law.IdLaw
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create_Part(LawPartViewModel part)
        {
            _context.Attach(part.اقسام);
            _context.Entry(part.اقسام).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("PartPage");
        }
        [HttpGet]
        public IActionResult Edit_Part(long Id)
        {
            Partقسمكتابباب parts = _context.Partقسمكتاببابs.Where(p => p.IdS == Id).FirstOrDefault();
            return View(parts);
        }
        [HttpPost]
        public IActionResult Edit_Part(Partقسمكتابباب parts)
        {
            _context.Attach(parts);
            _context.Entry(parts).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("PartPage");
        }
        public IActionResult Part_Details(long Id)
        {
            Partقسمكتابباب parts = _context.Partقسمكتاببابs.Where(p => p.IdS == Id).FirstOrDefault();
            return View(parts);
        }
        //-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.

        //Method to return an array of parts
        public Array GetSections()
        {
            Array sections = _context.Sectionكتابقسمs
                .Select(p => new Sectionكتابقسم { اسمالباب = p.اسمالباب, IdB = p.IdB , IdP = p.IdP }).ToArray();
            return sections;
        }

        //ActionMethod To return a viewmodel that contains the properties of Law and parts to combine them togther
        public ActionResult BookPage(string SearchText = "", int pg = 1)
        {
            List<Bookكتابقسمباب> books = _context.Bookكتابقسمبابs.ToList();
            if (SearchText != "" && SearchText != null)
            {
                books = _context.Bookكتابقسمبابs.Where(p => p.اسمالكتاب
                .Contains(SearchText)).ToList();
            }
            int i = SearchPager(books, pg, "BookPage", "Staff", SearchText);
            int recSkip = (pg - 1) * i;
            books = books.Skip(recSkip).Take(i).ToList();
            var model = new BookSectionViewModel
            {
                books = books,
                أبواب = GetSections()
            };

            return View(model);
        }
        //Actions that are performed in the Law_part viewModel
        [HttpGet]
        public ActionResult Create_Book()
        {
            Bookكتابقسمباب book = new Bookكتابقسمباب();
            List<Partقسمكتابباب> parts = _context.Partقسمكتاببابs.ToList();
            var model = new PartBookViewModel
            {
                book = book,
                parts = parts,
                IdS = book.IdS
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create_Book(PartBookViewModel part)
        {
            _context.Attach(part.book);
            _context.Entry(part.book).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("BookPage");
        }
        [HttpGet]
        public IActionResult Edit_Book(long Id)
        {
            Bookكتابقسمباب books = _context.Bookكتابقسمبابs.Where(p => p.IdB == Id).FirstOrDefault();
            return View(books);
        }
        [HttpPost]
        public IActionResult Edit_Book(Bookكتابقسمباب books)
        {
            _context.Attach(books);
            _context.Entry(books).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("BookPage");
        }
        public IActionResult Book_Details(long Id)
        {
            Bookكتابقسمباب books = _context.Bookكتابقسمبابs.Where(p => p.IdB == Id).FirstOrDefault();
            return View(books);
        }
        //-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.

        //Method to return an array of parts
        public Array GetChapters()
        {
            Array chapters = _context.Chapter1s
                .Select(p => new Chapter1 {اسمالفصل=p.اسمالفصل , IdP = p.IdP , IdChapter = p.IdChapter }).ToArray();
            return chapters;
        }

        //ActionMethod To return a viewmodel that contains the properties of Law and parts to combine them togther
        public ActionResult SectionPage(string SearchText = "", int pg = 1)
        {
            List<Sectionكتابقسم> sections = _context.Sectionكتابقسمs.ToList();
            if (SearchText != "" && SearchText != null)
            {
                sections = _context.Sectionكتابقسمs.Where(p => p.اسمالباب
                .Contains(SearchText)).ToList();
            }
            int i = SearchPager(sections, pg, "SectionPage", "Staff", SearchText);
            int recSkip = (pg - 1) * i;
            sections = sections.Skip(recSkip).Take(i).ToList();
            var model = new SectionChapterViewModels
            {
                sections = sections,
                chapters = GetChapters()
            };

            return View(model);
        }
        //Actions that are performed in the Law_part viewModel
        [HttpGet]
        public ActionResult Create_Section()
        {
            Sectionكتابقسم sections = new Sectionكتابقسم();
            List<Bookكتابقسمباب> books = _context.Bookكتابقسمبابs.ToList();
            var model = new BookSectionViewModel
            {
                ابواب = sections,
                books = books,
                IdBook = sections.IdB
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create_Section(BookSectionViewModel setion)
        {
            _context.Attach(setion.ابواب);
            _context.Entry(setion.ابواب).State = EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("SectionPage");
        }
        [HttpGet]
        public IActionResult Edit_Section(long Id)
        {
            Sectionكتابقسم sections = _context.Sectionكتابقسمs.Where(p => p.IdP == Id).FirstOrDefault();
            return View(sections);
        }
        [HttpPost]
        public IActionResult Edit_Section(Sectionكتابقسم sections)
        {
            _context.Attach(sections);
            _context.Entry(sections).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("SectionPage");
        }
        public IActionResult Section_Details(long Id)
        {
            Sectionكتابقسم sections = _context.Sectionكتابقسمs.Where(p => p.IdP == Id).FirstOrDefault();
            return View(sections);
        }
        //-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
         //Method to return an array of parts
        public Array GetChapter2()
        {
            Array chapter2 = _context.Chapter2s
                .Select(p => new Chapter2 { اسمالنقطه = p.اسمالنقطه, IdChapter = p.IdChapter , IdCh2 = p.IdCh2 }).ToArray();
            return chapter2;
        }
        public Array GetChapter3()
        {
            Array chapter3 = _context.Chapter3s
                .Select(p => new Chapter3 { محتويالنقطه = p.محتويالنقطه, IdCh2 = p.IdCh2 , IdCh3 = p.IdCh3 }).ToArray();
            return chapter3;
        }

        //ActionMethod To return a viewmodel that contains the properties of Law and parts to combine them togther
        public ActionResult ChapterPage(string SearchText = "", int pg = 1)
        {
            List<Chapter1> chapters = _context.Chapter1s.ToList(); ;
            if (SearchText != "" && SearchText != null)
            {
                chapters = _context.Chapter1s.Where(p => p.اسمالفصل
                .Contains(SearchText)).ToList();
            }
            int i = SearchPager(chapters, pg , "ChapterPage", "Staff", SearchText);
            int recSkip = (pg - 1) * i;
            chapters = chapters.Skip(recSkip).Take(i).ToList();
            var model = new AllChaptersViewModel
            {
                chapters = chapters,
                chapter2 = GetChapter2(),
                chapter3 = GetChapter3()
            };

            return View(model);
        }
        public int GetLastChapterId()
        {
            int ch_id = _context.Chapter1s.Select(p=>p.IdChapter).First();
            return ch_id;
        }
        //Actions that are performed in the Law_part viewModel
        [HttpGet]
        public ActionResult Create_Chapter()
        {
            Chapter1 chapters = new Chapter1();
            Chapter3 chapters3 = new Chapter3();
            List<Sectionكتابقسم> sections = _context.Sectionكتابقسمs.ToList();
            var model = new SectionChapterViewModels
            {
                chapter = chapters,
                sections = sections,
                Chapter2_names = null,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create_Chapter(SectionChapterViewModels chapters)
        {
            List<Chapter2> chapter22 = new List<Chapter2>();
            List<Chapter3> chapter33 = new List<Chapter3>();
            
            //first adding chapters to the dbcontext
            _context.Attach(chapters.chapter);

            _context.Entry(chapters.chapter).State = EntityState.Added;

            _context.SaveChanges();
            //second adding list of chapters2 to the dbcontext using inserting in list of type chapter2 first then add this list to dbcontext using addrange method
                foreach (string value in chapters.Chapter2_names)
                {
                    if (value != null)
                    {
                        //first defining object of chapter2 that will contain data from "chapter2_names"
                        Chapter2 chapters2 = new Chapter2();

                        chapters2.IdChapter = chapters.chapter.IdChapter;
                        chapters2.اسمالنقطه = value;

                        //list of objects of type chapter2
                        chapter22.Add(chapters2);
                    }
                }

            //last step adding this list to dbcontext and save...
            _context.Chapter2s.AddRange(chapter22);
            _context.SaveChanges();
           
            //third adding list of chapter3 to the dbcontext using inserting in list of type chapter3 first then add this list to dbcontext using addrange method
            if (chapters.Chapter3_names != null)
            {
                // incremental variable will be used as indexer
                int i = 0;
                //getting the length of the list of chapter2
                int length = chapter22.Count();

                foreach (string value2 in chapters.Chapter3_names)
                {
                    if (value2 != null)
                    {
                        //first defining object of chapter3 that will contain data from "chapter3_names"
                        Chapter3 chapters3 = new Chapter3();

                        if (i < length)
                        {
                            chapters3.IdCh2 = chapter22[i].IdCh2;
                        }
                        chapters3.محتويالنقطه = value2;

                        //list of objects of chapter3
                        chapter33.Add(chapters3);
                    }
                    //if the value is not equal to null or even equal to null the indexer will incerment to specify the value that it stops in the list of chapter2
                    i++;
                }

            }
            
            _context.Chapter3s.AddRange(chapter33);
            _context.SaveChanges();

            return RedirectToAction("ChapterPage");
        }

        [HttpGet]
        public IActionResult Edit_Chapter(long Id )
        {
            Chapter1 chapters = _context.Chapter1s.Where(p => p.IdChapter == Id).FirstOrDefault();
            List<int> chapters2 = _context.Chapter2s.Where(p => p.IdChapter == Id).Select(p=>p.IdCh2).ToList();
            Chapter2 chapters22 = new Chapter2();

            List<Chapter2> chapter2 = _context.Chapter2s.Where(p => p.IdChapter == Id).ToList();
            List<Chapter3> chapter3 = _context.Chapter3s.Where(p=> chapters2.Contains((int)p.IdCh2)).ToList();
            var model = new SectionChapterViewModels
            {
                chapter = chapters,
                chapters2 = chapters22,
                chapter2 = chapter2,
                chapter3 = chapter3,
 

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit_Chapter(SectionChapterViewModels viewmodel)
        {
            _context.Attach(viewmodel.chapter);


            _context.Entry(viewmodel.chapter).State = EntityState.Modified;

            _context.SaveChanges();

            if (viewmodel.chapter2 != null)
            {
                for (int i = 0; i < viewmodel.chapter2.Count(); i++)
                {

                    _context.Attach(viewmodel.chapter2[i]);


                    _context.Entry(viewmodel.chapter2[i]).State = EntityState.Modified;


                    _context.SaveChanges();
                }
            }
            if (viewmodel.chapter3 != null)
            {
                for (int j = 0; j < viewmodel.chapter3.Count(); j++)
                {

                    _context.Attach(viewmodel.chapter3[j]);


                    _context.Entry(viewmodel.chapter3[j]).State = EntityState.Modified;


                    _context.SaveChanges();
                }
            }
            return RedirectToAction("ChapterPage");
        }


        [HttpGet]
        public IActionResult Add_Contents(long Id)
        {

            List<Chapter2> chapter2 = _context.Chapter2s.Where(p => p.IdChapter == Id).ToList();
            Chapter1 chapter = new Chapter1();
            chapter.IdChapter = (int)Id;
            var model = new SectionChapterViewModels
            {
                chapter = chapter,
                Chapter2_names = null,
                chapter2 = chapter2,
                Chapter3_names = null,
                id = (int)Id
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Add_Contents(SectionChapterViewModels sectionchapter)
        {
            List<Chapter3> chapter33 = new List<Chapter3>();
            List<Chapter2> chapter22 = new List<Chapter2>();
            foreach (string value in sectionchapter.Chapter2_names)
            {
                if (value != null)
                {
                    Chapter2 chapters2 = new Chapter2();

                    chapters2.IdChapter = sectionchapter.chapter.IdChapter;
                    chapters2.اسمالنقطه = value;

                    chapter22.Add(chapters2);
                }
            }
            _context.Chapter2s.AddRange(chapter22);
            _context.SaveChanges();

            int ch2id = _context.Chapter2s.Where(p => p.اسمالنقطه == sectionchapter.chapters2.اسمالنقطه).Select(p => p.IdCh2).FirstOrDefault();
            if (ch2id == 0)
            {
                ch2id = _context.Chapter2s.Where(p => p.IdCh2.ToString() == sectionchapter.chapters2.اسمالنقطه).Select(p => p.IdCh2).FirstOrDefault();
            }


            foreach (string value in sectionchapter.Chapter3_names)
            {
                if (value != null)
                {
                    Chapter3 chapters3 = new Chapter3();

                    chapters3.IdCh2 = ch2id;

                    chapters3.محتويالنقطه = value;

                    chapter33.Add(chapters3);
                }
            }
            _context.Chapter3s.AddRange(chapter33);
            _context.SaveChanges();
            return RedirectToAction("ChapterPage");
        }


        public IActionResult Chapter_Details(long Id)
        {
            Chapter1 chapters = _context.Chapter1s.Where(p => p.IdChapter == Id).FirstOrDefault();
            List<Chapter2>chapters2 = _context.Chapter2s.Where(p => p.IdChapter == Id).ToList();
            List<Chapter3> chapters3 = _context.Chapter3s.ToList();
            var model = new SectionChapterViewModels
            {
                chapter = chapters,
                chapter2 = chapters2,
                chapter3 = chapters3
            };
            return View(model);
        }
        //-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
        public IActionResult SubjectPage(string SearchText = "", int pg = 1)
        {
            List<Subjectsمواد> subjects = _context.Subjectsموادs.ToList(); ;
            if (SearchText != "" && SearchText != null)
            {
                subjects = _context.Subjectsموادs.Where(p => p.رقمالماده
                .Contains(SearchText)).ToList();
            }
            int i  = SearchPager(subjects, pg, "SubjectPage", "Staff", SearchText);
            int recSkip = (pg - 1) * i;
            subjects = subjects.Skip(recSkip).Take(i).ToList();
            return View(subjects);
        }  
        
        public IActionResult Subject(string SearchText = "", int pg = 1)
        {
            List<Subjectsمواد> subjects = _context.Subjectsموادs.ToList(); ;
            if (SearchText != "" && SearchText != null)
            {
                subjects = _context.Subjectsموادs.Where(p => p.رقمالماده
                .Contains(SearchText)).ToList();
            }
            int i  = SearchPager(subjects, pg, "Subject", "Staff", SearchText);
            int recSkip = (pg - 1) * i;
            subjects = subjects.Skip(recSkip).Take(i).ToList();
            return View(subjects);
        }
        [HttpGet]
        public IActionResult Create_Subject()
        {
            List<Law> laws_list = _context.Laws.ToList();
            List<Partقسمكتابباب> parts_list = _context.Partقسمكتاببابs.ToList();
            List<Bookكتابقسمباب> books_list = _context.Bookكتابقسمبابs.ToList();
            List<Sectionكتابقسم> sections_list = _context.Sectionكتابقسمs.ToList();
            List<Chapter1> chapters1_list = _context.Chapter1s.ToList();
            List<Chapter2> chapters2_list = _context.Chapter2s.ToList();
            List<Chapter3> chapters3_list = _context.Chapter3s.ToList();
            Subjectsمواد subject = new Subjectsمواد();
            var model = new SubjectWithLawContentsViewModel
            {
                law_list = laws_list,
                part_list = parts_list,
                book_list = books_list,
                section_list = sections_list,
                chapter1_list = chapters1_list,
                chapter2_list = chapters2_list,
                chapter3_list = chapters3_list,
                subject = subject
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create_Subject(SubjectWithLawContentsViewModel subjectviewmodel)
        {
            if(subjectviewmodel.subject.التعديلالسابقللماده != null)
            {
                subjectviewmodel.subject.حالهالماده = "معدله";
            }
            _context.Attach(subjectviewmodel.subject);
            _context.Entry(subjectviewmodel.subject).State = EntityState.Added;
            _context.SaveChanges();

            return RedirectToAction("SubjectPage");
        }
        public IActionResult Details(long Id)
        {
            Subjectsمواد subjects = _context.Subjectsموادs.Where(p => p.IdSubjects == Id).FirstOrDefault();
            return View(subjects);
        }
        [HttpGet]
        public IActionResult Edit(long Id)
        {
            Subjectsمواد subjects = _context.Subjectsموادs.Where(p => p.IdSubjects == Id).FirstOrDefault();
            return View(subjects);
        }
        [HttpPost]
        public IActionResult Edit(Subjectsمواد subjects)
        {
            _context.Attach(subjects);
            _context.Entry(subjects).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("SubjectPage");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("RequestNotFound", id);
            }

            var subjects = await _context.Subjectsموادs.FindAsync(id);

            if (subjects == null)
            {
                Response.StatusCode = 404;
                return View("RequestNotFound", id);
            }

            _context.Subjectsموادs.Remove(subjects);
            _context.SaveChanges();

            return Ok();
        }


    }
}
