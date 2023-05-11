using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void TAdd(Page t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Page t)
        {
            throw new NotImplementedException();
        }

        public Page TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Page> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Page> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Page t)
        {
            throw new NotImplementedException();
        }
    }
}
