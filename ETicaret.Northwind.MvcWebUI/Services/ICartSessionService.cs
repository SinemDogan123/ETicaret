using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
