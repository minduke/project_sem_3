﻿using GiveAID.Helpers;
using System.Web;
using System.Web.Mvc;

namespace GiveAID
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ExceptionHandlingAttributeMVC());
        }
    }
}
