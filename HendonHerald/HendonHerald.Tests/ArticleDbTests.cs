using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HendonHerald.DAL.Repositories;
using HendonHerald.DAL.Entities;

namespace HendonHerald.Tests
{
	[TestFixture]
	public class ArticleDbTests
	{
		[Test]
		public void CRUD_Integration_Test()
		{
			GenericUnitOfWork unitOfWork = new GenericUnitOfWork();
			Article article = new Article();

			article.Title = "Test article";
			article.Body = "Test body";

			unitOfWork.Repository<Article>().Add(article);
			unitOfWork.SaveChanges();

			Article retrievedArticle = unitOfWork.Repository<Article>().GetSingle(s => s.Id == article.Id);

			Assert.AreEqual(article, retrievedArticle);

			retrievedArticle.Body = "Updated test body";

			unitOfWork.Repository<Article>().Update(retrievedArticle);

			unitOfWork.SaveChanges();

			retrievedArticle = unitOfWork.Repository<Article>().GetSingle(s => s.Id == article.Id);

			Assert.AreEqual("Updated test body", retrievedArticle.Body);

			unitOfWork.Repository<Article>().Delete(retrievedArticle);
			unitOfWork.SaveChanges();

			retrievedArticle = unitOfWork.Repository<Article>().GetSingle(s => s.Id == article.Id);

			Assert.IsNull(retrievedArticle);

		}
	}
}
