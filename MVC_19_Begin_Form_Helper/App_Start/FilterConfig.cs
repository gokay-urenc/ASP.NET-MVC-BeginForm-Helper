﻿using System.Web;
using System.Web.Mvc;

namespace MVC_19_Begin_Form_Helper
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
