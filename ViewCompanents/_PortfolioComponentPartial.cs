using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewCompanents
{
    public class _PortfolioComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {

        return View(); }
    }

}

