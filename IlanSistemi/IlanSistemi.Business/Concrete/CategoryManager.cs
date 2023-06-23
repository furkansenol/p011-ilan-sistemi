using IlanSistemi.Business.Abstract;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.Entities.Concrete;
using IlanSistemi.Entities.ViewModels;
using System.Linq.Expressions;

namespace IlanSistemi.Business.Concrete
{
    public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _CategoryDal;

		public CategoryManager(ICategoryDal CategoryDal)
		{
			_CategoryDal = CategoryDal;
		}

		public void TAdd(Category t)
		{
			_CategoryDal.Insert(t);
		}

		public void TDelete(Category t)
		{
			_CategoryDal.Delete(t);
		}

		public Category TGetByID(int id)
		{
			return _CategoryDal.GetByID(id);
		}

		public List<Category> TGetList()
		{
			return _CategoryDal.GetList();
		}

		public List<Category> TGetListbyFilter(Expression<Func<Category, bool>> filter)
		{
			return _CategoryDal.GetByFilter(filter);
		}

		public void TUpdate(Category t)
		{
			_CategoryDal.Update(t);
		}

		public async Task<List<Advert>> GetCategoryAdverts(int categoryId)
		{
			return await _CategoryDal.GetCategoryAdverts(categoryId);
		}

        public async Task<List<AdvertVM>> GetCategoriesOfUserAdverts(int userId)
        {
			return await _CategoryDal.GetCategoriesOfUserAdverts(userId);
        }
    }
}
