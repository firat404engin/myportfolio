using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewCompanents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
