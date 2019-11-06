﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.MvcWebUI.Models;
using ETicaret.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ETicaret.Northwind.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}
