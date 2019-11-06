using System.Collections.Generic;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}