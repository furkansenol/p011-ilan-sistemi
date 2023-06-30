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
    public class PageManager : IPageService
    {
        IPageDal _pageDal;

        public PageManager(IPageDal pageDal)
        {
            _pageDal = pageDal;
		}

		public async Task ActivePage(int id)
		{
			var page = _pageDal.GetByID(id);
			if (page != null)
			{
				page.IsActive = true;
				_pageDal.Update(page);
			}
		}

		public async Task PassivePage(int id)
		{
			var page = _pageDal.GetByID(id);
			if (page != null)
			{
				page.IsActive = false;
				_pageDal.Update(page);
			}
		}

		public void TAdd(Page t)
		{
			_pageDal.Insert(t);
		}

		public void TDelete(Page t)
		{
			_pageDal.Delete(t);
		}

		public Page TGetByID(int id)
		{
			return _pageDal.GetByID(id);
		}

		public List<Page> TGetList()
		{
			return _pageDal.GetList();
		}

		public List<Page> TGetListbyFilter(Expression<Func<Page, bool>> filter)
		{
			return _pageDal.GetByFilter(filter);
		}

		public void TUpdate(Page t)
		{
			_pageDal.Update(t);		
		}
	}
}
