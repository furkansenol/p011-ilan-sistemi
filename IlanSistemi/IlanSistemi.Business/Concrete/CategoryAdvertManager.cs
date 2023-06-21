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
	public class CategoryAdvertManager : ICategoryAdvertService
	{
		ICategoryAdvertDal _categoryAdvertDal;

		public CategoryAdvertManager(ICategoryAdvertDal categoryAdvertDal)
		{
			_categoryAdvertDal = categoryAdvertDal;
		}

		public void TAdd(CategoryAdvert t)
		{
			_categoryAdvertDal.Insert(t);
		}

		public void TDelete(CategoryAdvert t)
		{
			_categoryAdvertDal.Delete(t);
		}

		public CategoryAdvert TGetByID(int id)
		{
			return _categoryAdvertDal.GetByID(id);
		}

		public List<CategoryAdvert> TGetList()
		{
			return _categoryAdvertDal.GetList();
		}

		public List<CategoryAdvert> TGetListbyFilter(Expression<Func<CategoryAdvert, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(CategoryAdvert t)
		{
			_categoryAdvertDal.Update(t);
		}
	}
}
