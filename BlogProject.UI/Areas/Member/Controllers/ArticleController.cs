using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.UI.Areas.Member.Controllers
{
    public class ArticleController : BaseController
    {
       
        public ActionResult Index()
        {
            return View();
        }
    }
}