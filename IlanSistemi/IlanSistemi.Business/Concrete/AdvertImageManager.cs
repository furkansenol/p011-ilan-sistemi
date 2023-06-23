using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.Entities.Concrete;
using System.Linq.Expressions;

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
			_advertImageDal.Insert(t);
		}

		public void TDelete(AdvertImage t)
		{
			_advertImageDal.Delete(t);
		}

		public AdvertImage TGetByID(int id)
		{
			return _advertImageDal.GetByID(id);
		}

		public List<AdvertImage> TGetList()
		{
			return _advertImageDal.GetList();
		}

		public List<AdvertImage> TGetListbyFilter(Expression<Func<AdvertImage, bool>> filter)
		{
			return _advertImageDal.GetByFilter(filter);
		}

		public void TUpdate(AdvertImage t)
		{
			_advertImageDal.Update(t);
		}
	}
}
