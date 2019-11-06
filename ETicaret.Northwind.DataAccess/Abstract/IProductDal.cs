using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Core.DataAccess;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Custom Operations
    }
}
