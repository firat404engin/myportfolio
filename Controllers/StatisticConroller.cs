using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticConroller : Controller
	{
		MyPortfolioContext context= new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skillss.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3=context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
			return View();
		}
	}
}
