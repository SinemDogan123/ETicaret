using ETicaret.Core.DataAccess;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}