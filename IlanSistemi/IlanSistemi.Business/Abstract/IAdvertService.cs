using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Business.Abstract
{
	public interface IAdvertService : IGenericService <Advert>
	{
        List<AdvertVM> GetAllAdvertsWithImage();
    }
}
