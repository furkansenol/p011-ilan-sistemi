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
    public class AdminUserManager : IAdminUserService
    {
        IAdminUserDal _adminUser;

        public AdminUserManager(IAdminUserDal adminUser)
        {
            _adminUser = adminUser;
        }

        public void TAdd(AdminUser t)
        {
            _adminUser.Insert(t);
        }

        public void TDelete(AdminUser t)
        {
            _adminUser.Delete(t);
        }

        public AdminUser TGetByID(int id)
        {
            return _adminUser.GetByID(id);
        }

        public List<AdminUser> TGetList()
        {
            return _adminUser.GetList();
        }

        public List<AdminUser> TGetListbyFilter(Expression<Func<AdminUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AdminUser t)
        {
            _adminUser.Update(t);
        }
    }
}
