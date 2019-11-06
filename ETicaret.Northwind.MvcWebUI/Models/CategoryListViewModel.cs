using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
