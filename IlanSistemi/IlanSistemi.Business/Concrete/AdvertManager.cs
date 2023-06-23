using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using System.Linq.Expressions;

namespace IlanSistemi.Business.Concrete
{
    public class AdvertManager : IAdvertService
	{
		IAdvertDal _advertDal;

		public AdvertManager(IAdvertDal advertDal)
		{
			_advertDal = advertDal;
		}

        public List<AdvertVM> GetAllAdvertsWithImage()
        {
            return _advertDal.GetAllAdvertsWithImage();
        }

        public void TAdd(Advert t)
		{
			_advertDal.Insert(t);
		}

		public void TDelete(Advert t)
		{
			_advertDal.Delete(t);
		}

		public Advert TGetByID(int id)
		{
			return _advertDal.GetByID(id);
		}

		public List<Advert> TGetList()
		{
			return _advertDal.GetList();
		}

		public List<Advert> TGetListbyFilter(Expression<Func<Advert, bool>> filter)
		{
			return _advertDal.GetByFilter(filter);
		}

		public void TUpdate(Advert t)
		{
			_advertDal.Update(t);
		}
	}
}
