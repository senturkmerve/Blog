﻿using BlogProject.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.UI.Areas.Author.Controllers
{
    public class BaseController : Controller
    {
        protected EntityService service = new EntityService();
    }
}