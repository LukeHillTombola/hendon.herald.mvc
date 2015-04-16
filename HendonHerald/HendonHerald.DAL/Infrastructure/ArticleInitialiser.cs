using System.Collections.Generic;
using System.Data.Entity;
using HendonHerald.Models;

namespace HendonHerald.DAL
{
	public class ArticleInitialiser : DropCreateDatabaseAlways<ArticleDbContext>
	{
		protected override void Seed(ArticleDbContext context)
		{
			var articles = new List<ArticleModel>
			{
				new ArticleModel {Title = "Amy's Winehouse", Body = "Amy's Winehouse body text"},
				new ArticleModel {Title = "Blandford Street Found Wonky", Body = "Blandford Street body text"},
				new ArticleModel {Title = "Spectral Figure Found In Mowbray Park", Body = "Spectral Figure body text"},
			};

			articles.ForEach(s => context.ArticleModels.Add(s));
			context.SaveChanges();

			var images = new List<ArticleImageModel>
			{
				new ArticleImageModel {ImageName = "AmysWinehouse.jpg", AltText = "Amy's Corner Shop", Height = 300, Width = 300, ArticleId = 1},
				new ArticleImageModel {ImageName = "CrookedBlandfordStreet.jpg", AltText = "Not quite straight", Height = 300, Width = 300, ArticleId = 2},
				new ArticleImageModel {ImageName = "SpectralFigureDiscoveredInMowbrayPark.jpg", AltText = "A ghastly sight!", Height = 300, Width = 300, ArticleId = 3},
			};

			images.ForEach(i => context.ArticleImageModels.Add(i));
			context.SaveChanges();
		}
	}
}