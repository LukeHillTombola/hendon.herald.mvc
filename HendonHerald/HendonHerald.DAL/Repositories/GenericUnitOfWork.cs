using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendonHerald.DAL.Repositories
{
	public class GenericUnitOfWork : IDisposable
	{
		private ArticleDbContext _db = null;

		public GenericUnitOfWork()
		{
			_db = new ArticleDbContext();
		}

		public Dictionary<Type, object> repositories = new Dictionary<Type,object>();

		public IRepository<T> Repository<T>() where T :  class
		{
			if (repositories.Keys.Contains(typeof(T)))
			{
				return repositories[typeof(T)] as IRepository<T>;
			}
			else
			{
				IRepository<T> repo = new GenericRepository<T>(_db);
				repositories.Add(typeof(T), repo);
				return repo;
			}
		}

		public void SaveChanges()
		{
			_db.SaveChanges();
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_db.Dispose();
				}
			}

			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
