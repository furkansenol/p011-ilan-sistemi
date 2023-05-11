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
    public class SettingManager : ISettingService
    {
        ISettingDal _settingDal;

        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }

        public void TAdd(Setting t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Setting t)
        {
            throw new NotImplementedException();
        }

        public Setting TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Setting> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Setting> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Setting t)
        {
            throw new NotImplementedException();
        }
    }
}
