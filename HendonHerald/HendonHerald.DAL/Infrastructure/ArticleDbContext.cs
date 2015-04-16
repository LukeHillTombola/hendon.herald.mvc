using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using HendonHerald.DAL.Entities;

namespace HendonHerald.DAL
{
	public class ArticleDbContext : DbContext
	{
		public ArticleDbContext() : base("DefaultConnection")
		{
			
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public DbSet<ArticleImage> ArticleImages { get; set; }

		public DbSet<Article> Articles { get; set; }
	}
}