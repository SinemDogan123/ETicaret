using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Core.DataAccess.EntityFramework;
using ETicaret.Northwind.DataAccess.Abstract;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
