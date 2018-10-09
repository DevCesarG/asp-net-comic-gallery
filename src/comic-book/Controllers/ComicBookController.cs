using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book.Controllers
{
    public class ComicBookController : Controller
    {
        public ContentResult Detail(){
            return new ContentResult()
            {
                Content = "Hello world"
            };
        }
    }
}