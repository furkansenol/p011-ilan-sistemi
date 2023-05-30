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
	public class AdvertManager : IAdvertService
	{
		IAdvertDal _advertDal;

		public AdvertManager(IAdvertDal advertDal)
		{
			_advertDal = advertDal;
		}

		public void TAdd(Advert t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Advert t)
		{
			throw new NotImplementedException();
		}

		public Advert TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Advert> TGetList()
		{
			throw new NotImplementedException();
		}

		public List<Advert> TGetListbyFilter(Expression<Func<Advert, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Advert t)
		{
			throw new NotImplementedException();
		}
	}
}
