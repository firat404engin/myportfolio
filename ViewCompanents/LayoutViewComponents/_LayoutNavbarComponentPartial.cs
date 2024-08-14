using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewCompanents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();	
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount= context.ToDoList.Where(x => x.Status == false).Count(); // tamamlanmamış bildirim sayısı
			var values = context.ToDoList.Where(x => x.Status == false ).ToList();
			return View(values); 
		
		}
	}
}
