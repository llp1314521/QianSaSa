﻿using System.Web;
using System.Web.Mvc;

namespace QSS.P2P.BackUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}