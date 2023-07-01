using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.DataAccess.EntityFramework;
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
		IAdvertCommentDal _advertCommentDal;

		public AdvertCommentManager(IAdvertCommentDal advertCommentDal)
		{
			this._advertCommentDal = advertCommentDal;
		}

		public async Task Active(int Id)
		{
			var comment = _advertCommentDal.GetByID(Id);

			if (comment != null)
			{
				comment.IsActive = true;
				_advertCommentDal.Update(comment);
			}
		}

		public async Task Passive(int Id)
		{
			var comment = _advertCommentDal.GetByID(Id);

			if (comment != null)
			{
				comment.IsActive = false;
				_advertCommentDal.Update(comment);
			}
		}

		public void TAdd(AdvertComment t)
		{
			_advertCommentDal.Insert(t);
		}

		public void TDelete(AdvertComment t)
		{
			_advertCommentDal.Delete(t);
		}

		public AdvertComment TGetByID(int id)
		{
			return _advertCommentDal.GetByID(id);
		}

		public List<AdvertComment> TGetList()
		{
			return _advertCommentDal.GetList();
		}

		public List<AdvertComment> TGetListbyFilter(Expression<Func<AdvertComment, bool>> filter)
		{
			return _advertCommentDal.GetByFilter(filter);
		}

		public void TUpdate(AdvertComment t)
		{
			_advertCommentDal.Update(t);
		}
	}

}
