using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlanSistemi.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Advert>> GetCategoryAdverts(int categoryId);
        Task<List<AdvertVM>> GetCategoriesOfUserAdverts(int userId);
    }
}
