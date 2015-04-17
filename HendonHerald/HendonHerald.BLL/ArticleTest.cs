using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HendonHerald.DAL.Repositories;
using HendonHerald.DAL.Entities;
using HendonHerald.BLL.Models;

namespace HendonHerald.BLL
{
	public class ArticleTest
	{
		private GenericUnitOfWork _singleDBAccess;

		public ArticleTest()
		{
			_singleDBAccess = new GenericUnitOfWork();
		}

		public ArticleModel GetSingleArticle(int Id)
		{
			Article foundArticle = _singleDBAccess.Repository<Article>().GetSingle(a => a.Id == Id);

			return ConvertArticleToModel(foundArticle);
		}

		private ArticleModel ConvertArticleToModel(Article orig)
		{
			ArticleModel retModel = new ArticleModel();
			retModel.Id = orig.Id;
			retModel.Title = orig.Title;
			retModel.Body = orig.Body;

			return retModel;
		}
	}
}
