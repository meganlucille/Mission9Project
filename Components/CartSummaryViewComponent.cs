using Microsoft.AspNetCore.Mvc;
using Mission9Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9Project.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        // cart summary, followed textbook instructions
        private Basket basket;
        public CartSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}