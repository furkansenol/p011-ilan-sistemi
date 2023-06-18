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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

		public void TAdd(Users t)
		{
			_userDal.Insert(t);

        }

		public void TDelete(Users t)
		{
			_userDal.Delete(t);
		}

		public Users TGetByID(int id)
		{
			return _userDal.GetByID(id);
		}

		public List<Users> TGetList()
		{
			return _userDal.GetList();
		}

		public List<Users> TGetListbyFilter(Expression<Func<Users, bool>> filter)
		{
			return _userDal.GetByFilter(filter);
		}

		public void TUpdate(Users t)
		{
			_userDal.Update(t);
		}
	}
}
