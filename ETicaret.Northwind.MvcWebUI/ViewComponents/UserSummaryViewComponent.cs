﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ETicaret.Northwind.MvcWebUI.ViewComponents
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            
            UserDetailsViewModel model = new UserDetailsViewModel
            {
               UserName = HttpContext.User.Identity.Name
            };
            return View(model);
        }
    }
}