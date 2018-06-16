using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComibBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                
                SeriesTitle = "The Amazing Spider-man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name="Dan Slott",Role="Script"},
                    new Artist() {Name="Humberto Ramos",Role="Pencils"},
                    new Artist() {Name="Victor Olazaba",Role="Inks"},
                    new Artist() {Name="Edgar Delgado",Role="Colors"},
                    new Artist() {Name="Chris Eliopoulos",Role="Letters"}
                }

            };


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
        