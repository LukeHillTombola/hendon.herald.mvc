using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HendonHerald.BLL.Models;

namespace HendonHerald.Controllers
{
	public class HomeController : Controller
	{
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

			return View();
		}

		public ActionResult ListImages(int id)
		{
			ViewBag.Message = "Getting Images";

			return View();
		}
	}
}