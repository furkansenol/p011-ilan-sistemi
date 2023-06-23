using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.Repository;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IlanSistemi.DataAccess.EntityFramework
{
    public class EfAdvertDal : GenericRepository<Advert>, IAdvertDal
    {
        public List<AdvertVM> GetAllAdvertsWithImage()
        {
            using var c = new DataContext();
            var adverts = c.adverts.Include(a => a.advertImages).ToList();

            var advertsWithImg = adverts.Select(a => new AdvertVM
            {
                Advert = a,
                AdvertImages = a.advertImages.ToList(),
                UserId = a.UsersId
            }).ToList();

            return advertsWithImg;
        }
    }
}
