
using System.ComponentModel.DataAnnotations.Schema;

namespace HendonHerald.Models
{
	public class ArticleImageModel
	{
		public int Id { get; set; }

		[ForeignKey("Article")]
		public int ArticleId {get; set; }

		public string ImageName { get; set; }
		public string AltText { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public virtual ArticleModel Article { get; set; }
	}
}
