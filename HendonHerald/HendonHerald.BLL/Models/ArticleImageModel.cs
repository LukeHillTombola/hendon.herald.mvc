using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendonHerald.BLL.Models
{
	public class ArticleImageModel
	{
		public int Id { get; set; }
		public string ImageName { get; set; }
		public string AltText { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
	}
}
