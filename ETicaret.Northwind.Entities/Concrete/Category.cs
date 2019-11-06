using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Core.Entities;

namespace ETicaret.Northwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
