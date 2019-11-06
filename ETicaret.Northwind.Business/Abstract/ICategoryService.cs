using System.Collections.Generic;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}