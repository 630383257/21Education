﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace _21Education.COMMON
{
    public static class UrlHelperExtend
    {
        public static string PageLink(this UrlHelper helper, int pageIndex)
        {
            return helper.RequestContext.RouteData.GetPath() + "/" + StringKeys.PageFormat(StringKeys.RouteValue_Page, pageIndex + 1);
        }

    }
}
