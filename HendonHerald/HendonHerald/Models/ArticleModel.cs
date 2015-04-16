using System.Collections.Generic;

namespace HendonHerald.Models
{
	public class ArticleModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }

		public virtual ICollection<ArticleImageModel> ArticleImages { get; set; } 
	}
}