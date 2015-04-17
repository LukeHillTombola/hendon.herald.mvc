using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace HendonHerald.DAL.Repositories
{
	public class GenericRepository<T> : IRepository<T> where T : class
	{
		private ArticleDbContext _db;
		DbSet<T> _objectSet;

		public GenericRepository(ArticleDbContext db)
		{
			_db = db;
			_objectSet = db.Set<T>();
		}

		public IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate = null)
		{
			if (predicate != null)
			{
				return _objectSet.Where(predicate);
			}

			return _objectSet.AsEnumerable();
		}

		public T GetSingle(Expression<Func<T, bool>> predicate)
		{
			return _objectSet.FirstOrDefault(predicate);
		}

		public void Add(T entity)
		{
			_objectSet.Add(entity);
		}

		public void Update(T entity)
		{
			_objectSet.Attach(entity);
		}

		public void Delete(T entity)
		{
			_objectSet.Remove(entity);
		}
	}
}
