using System.Collections.Generic;
using System.Data.Entity;
using HendonHerald.DAL.Entities;

namespace HendonHerald.DAL
{
	public class ArticleInitialiser : DropCreateDatabaseAlways<ArticleDbContext>
	{
		protected override void Seed(ArticleDbContext context)
		{
			var articles = new List<Article>
			{
				new Article {Title = "Amy's Winehouse", Body = "Amy's Winehouse body text"},
				new Article {Title = "Blandford Street Found Wonky", Body = "Blandford Street body text"},
				new Article {Title = "Spectral Figure Found In Mowbray Park", Body = "Spectral Figure body text"},
			};

			articles.ForEach(s => context.Articles.Add(s));
			context.SaveChanges();

			var images = new List<ArticleImage>
			{
				new ArticleImage {ImageName = "AmysWinehouse.jpg", AltText = "Amy's Corner Shop", Height = 300, Width = 300, ArticleId = 1},
				new ArticleImage {ImageName = "CrookedBlandfordStreet.jpg", AltText = "Not quite straight", Height = 300, Width = 300, ArticleId = 2},
				new ArticleImage {ImageName = "SpectralFigureDiscoveredInMowbrayPark.jpg", AltText = "A ghastly sight!", Height = 300, Width = 300, ArticleId = 3},
			};

			images.ForEach(i => context.ArticleImages.Add(i));
			context.SaveChanges();
		}
	}
}