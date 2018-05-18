using FirstChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class ComicBookController : Controller
    {
        private static List<ComicBook> _comicBooks = ComicBookManager.GetComicBooks();

        // GET: ComicBook
        public ActionResult Index()
        {
            return View(_comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.ComicBookId == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            if (comicBookToReturn == null)
            {
                return HttpNotFound();
            }
            return View(comicBookToReturn);
        }
    }
}