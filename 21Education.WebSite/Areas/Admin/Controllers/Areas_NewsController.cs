﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21Education.WebSite.Areas.Admin.Controllers
{
    [AdminAuthorize]
    public class Areas_NewsController : Controller
    {
        //
        // GET: /Admin/Areas_News/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewsList()
        {
            return View();
        }
    }
}
