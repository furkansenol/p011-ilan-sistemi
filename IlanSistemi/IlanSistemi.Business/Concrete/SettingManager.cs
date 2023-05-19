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
    public class SettingManager : ISettingService
    {
        ISettingDal _settingDal;

        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }

        public void TAdd(Setting t)
        {
            _settingDal.Insert(t);
        }

        public void TDelete(Setting t)
        {
            _settingDal.Delete(t);
        }

        public Setting TGetByID(int id)
        {
            return _settingDal.GetByID(id);
        }

        public List<Setting> TGetList()
        {
            return _settingDal.GetList();
        }

        public List<Setting> TGetListbyFilter(Expression<Func<Setting, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Setting t)
        {
            _settingDal.Update(t);
        }
    }
}
