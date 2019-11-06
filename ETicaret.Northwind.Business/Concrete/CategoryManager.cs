using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Northwind.Business.Abstract;
using ETicaret.Northwind.DataAccess.Abstract;
using ETicaret.Northwind.Entities.Concrete;

namespace ETicaret.Northwind.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
