using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart,int productId);
        List<CartLine> List(Cart cart);
    }

    
}
