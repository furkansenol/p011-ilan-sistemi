using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;

namespace IlanSistemi.DataAccess.Abstract
{
    public interface IAdvertDal : IGenericDal<Advert>
	{
		List<AdvertVM> GetAllAdvertsWithImage();

	}
}
