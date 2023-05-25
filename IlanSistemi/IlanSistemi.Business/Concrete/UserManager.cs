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
			throw new NotImplementedException();
		}

		public void TDelete(User t)
		{
			throw new NotImplementedException();
		}

		public User TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<User> TGetList()
		{
			throw new NotImplementedException();
		}

		public List<User> TGetListbyFilter(Expression<Func<User, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(User t)
		{
			throw new NotImplementedException();
		}
	}
}
