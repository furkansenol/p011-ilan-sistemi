using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.Repository;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace IlanSistemi.DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public async Task<List<AdvertVM>> GetCategoriesOfUserAdverts(int userId)
        {
            //using var c = new DataContext();

            //var data = c.users
            //    .Where(u => u.Id == userId)
            //    .Include(a => a.ad
            

            return null;
        }

        /// <summary>
        /// It returns Adverts from the category specified by id.
        /// </summary>
        /// <param name="categoryId">Category Id that you want to get advert list</param>
        /// <returns>Advert list</returns>
        public async Task<List<Advert>> GetCategoryAdverts(int categoryId)
        {
            using var c = new DataContext();
            var advertsId = await c.CategoryAdverts
                .Where(ca => ca.CategoryId == categoryId)
                .Select(ca => ca.AdvertId)
                .ToListAsync();

            var adverts = c.adverts
                .Include(a => a.advertImages)
                .Where(a => advertsId.Contains(a.Id))
                .ToList();

            return adverts;
        }
    }
}
