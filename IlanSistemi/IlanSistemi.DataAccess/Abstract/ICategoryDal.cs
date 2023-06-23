using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;

namespace IlanSistemi.DataAccess.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Advert>> GetCategoryAdverts(int categoryId);
        Task<List<AdvertVM>> GetCategoriesOfUserAdverts(int userId);

    }
}
