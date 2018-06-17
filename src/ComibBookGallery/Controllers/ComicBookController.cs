using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComibBookGallery.Data;
using ComibBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;


        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
                }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();


            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);


            return View(comicBook);

        }
         


    }    
}
// IssueNumber = 700;
    //  = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
    // Artists = new string[]
    //        {
    //"Script: Dan Slott",
    //"Pencils: Humberto Ramos",
    //"Inks: Victor Olazaba",
    //"Colors: Edgar Delgado",
    //"Letters: Chris Eliopoulos"
    // };



     

            //ViewBag.SeriesTitle = "The Amazing Spider-man";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
           // //{
           //"Script: Dan Slott",
           //"Pencils: Humberto Ramos",
           //"Inks: Victor Olazaba",
           //"Colors: Edgar Delgado",
           //"Letters: Chris Eliopoulos"
        