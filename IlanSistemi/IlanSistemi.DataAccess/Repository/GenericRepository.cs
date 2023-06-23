using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.DataAccess.Concrete;
using System.Linq.Expressions;

namespace IlanSistemi.DataAccess.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		
		public void Delete(T t)
		{
			using var c = new DataContext();
			c.Remove(t);
			c.SaveChanges();
		}

		public List<T> GetByFilter(Expression<Func<T, bool>> filter)
		{
			using var c = new DataContext();
			return c.Set<T>().Where(filter).ToList();
		}

		public T GetByID(int id)
		{
			using var c = new DataContext();
			return c.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			using var c = new DataContext();
			return c.Set<T>().ToList();
		}

		public void Insert(T t)
		{
			using var c = new DataContext();
			c.Add(t);
			c.SaveChanges();
		}

		public void Update(T t)
		{
			using var c = new DataContext();
			c.Update(t);
			c.SaveChanges();
		}

	}
}

