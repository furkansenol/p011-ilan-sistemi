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
	public class AdvertCommentManager : IAdvertCommentService
	{
		IAdvertCommentDal advertCommentDal;

		public AdvertCommentManager(IAdvertCommentDal advertCommentDal)
		{
			this.advertCommentDal = advertCommentDal;
		}

		public void TAdd(AdvertComment t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(AdvertComment t)
		{
			throw new NotImplementedException();
		}

		public AdvertComment TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<AdvertComment> TGetList()
		{
			throw new NotImplementedException();
		}

		public List<AdvertComment> TGetListbyFilter(Expression<Func<AdvertComment, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(AdvertComment t)
		{
			throw new NotImplementedException();
		}
	}

}
