using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void TAdd(Category t)
		{
			_categoryDal.Insert(t);
		}

		public void TDelete(Category t)
		{
			_categoryDal.Delete(t);
		}

		public Category TGetByID(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public List<Category> TGetList()
		{
			return _categoryDal.GetList();
		}

		public List<Category> TGetListbyFilter(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Category t)
		{
			_categoryDal.Update(t);
		}
	}
}
