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
		ICategoryAdvertDal _CategoryAdvertDal;

		public CategoryAdvertManager(ICategoryAdvertDal CategoryAdvertDal)
		{
			_CategoryAdvertDal = CategoryAdvertDal;
		}

		public void TAdd(CategoryAdvert t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(CategoryAdvert t)
		{
			throw new NotImplementedException();
		}

		public CategoryAdvert TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<CategoryAdvert> TGetList()
		{
			throw new NotImplementedException();
		}

		public List<CategoryAdvert> TGetListbyFilter(Expression<Func<CategoryAdvert, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(CategoryAdvert t)
		{
			throw new NotImplementedException();
		}
	}
}
