using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HendonHerald.Models;

namespace HendonHerald.Controllers
{
	public class HomeController : Controller
	{
		private ArticleDbContext _db = new ArticleDbContext();

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult ListData()
		{
			ViewBag.Message = "Listing Data:";

			return View(_db.ArticleModels);
		}

		public ActionResult ListImages(int id)
		{
			ViewBag.Message = "Getting Images";

			ArticleModel cModel = _db.ArticleModels.Find(id);

			return View(cModel.ArticleImages);
		}
	}
}