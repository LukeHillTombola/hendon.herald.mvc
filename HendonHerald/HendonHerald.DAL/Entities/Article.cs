using System.Collections.Generic;

namespace HendonHerald.DAL.Entities
{
	public class Article
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }

		public virtual ICollection<ArticleImage> ArticleImages { get; set; } 
	}
}