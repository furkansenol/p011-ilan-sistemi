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

		public void TAdd(User t)
		{
			_userDal.Insert(t);

        }

		public void TDelete(User t)
		{
			_userDal.Delete(t);
		}

		public User TGetByID(int id)
		{
			return _userDal.GetByID(id);
		}

		public List<User> TGetList()
		{
			return _userDal.GetList();
		}

		public List<User> TGetListbyFilter(Expression<Func<User, bool>> filter)
		{
			return _userDal.GetByFilter(filter);
		}

		public void TUpdate(User t)
		{
			_userDal.Update(t);
		}
	}
}
