using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail(){
            // Check if day of the week is monday for specials, redirect to specials page
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday){
                return Redirect("/");
            }

            return Content("Details page");
        }
    }
}