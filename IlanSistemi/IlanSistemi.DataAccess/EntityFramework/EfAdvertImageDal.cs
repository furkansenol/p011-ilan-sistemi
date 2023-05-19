using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.DataAccess.Repository;
using IlanSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.DataAccess.EntityFramework
{
	public class EfAdvertImageDal : GenericRepository<AdvertImage> , IAdvertImageDal
	{
	}
}
