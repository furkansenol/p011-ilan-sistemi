using IlanSistemi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Business.Abstract
{
	public interface IUserService : IGenericService<Users>
	{
		Task BanUser(int Id);
		Task UnbanUser(int Id);
		Task SuspendUserForDuration(int userId, TimeSpan duration);
		Task UnsuspendUser(int userId);

 
    }
}
