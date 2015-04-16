
using System.ComponentModel.DataAnnotations.Schema;

namespace HendonHerald.DAL.Entities
{
	public class ArticleImage
	{
		public int Id { get; set; }

		[ForeignKey("Article")]
		public int ArticleId {get; set; }

		public string ImageName { get; set; }
		public string AltText { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public virtual Article Article { get; set; }
	}
}
