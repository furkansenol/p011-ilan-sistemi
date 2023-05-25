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
	public class AdvertImageManager : IAdvertImageService
	{
		IAdvertImageDal _advertImageDal;

		public AdvertImageManager(IAdvertImageDal advertImageDal)
		{
			_advertImageDal = advertImageDal;
		}

		public void TAdd(AdvertImage t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(AdvertImage t)
		{
			throw new NotImplementedException();
		}

		public AdvertImage TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<AdvertImage> TGetList()
		{
			throw new NotImplementedException();
		}

		public List<AdvertImage> TGetListbyFilter(Expression<Func<AdvertImage, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(AdvertImage t)
		{
			throw new NotImplementedException();
		}
	}
}
