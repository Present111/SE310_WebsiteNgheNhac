﻿using System.Web;
using System.Web.Mvc;

namespace SE310_WebsiteNgheNhac
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}