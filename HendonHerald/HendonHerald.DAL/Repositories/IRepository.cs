using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace HendonHerald.DAL.Repositories
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate = null);
		T GetSingle(Expression<Func<T, bool>> predicate);

		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
