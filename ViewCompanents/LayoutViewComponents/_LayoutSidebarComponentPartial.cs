using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewCompanents.LayoutViewComponents

{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("Default");
		}
	}
}
