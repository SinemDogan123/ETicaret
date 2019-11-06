using ETicaret.Northwind.Entities.Concrete;
using ETicaret.Core.DataAccess.EntityFramework;
using ETicaret.Northwind.DataAccess.Abstract;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}