using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using HendonHerald.Models;

namespace HendonHerald
{
	public class ArticleDbContext : DbContext
	{
		public ArticleDbContext() : base("DefaultConnection")
		{
			
		}

		public DbSet<ArticleImageModel> ArticleImageModels { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public DbSet<ArticleModel> ArticleModels { get; set; }
	}
}