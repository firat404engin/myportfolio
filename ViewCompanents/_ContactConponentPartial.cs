using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewCompanents
{
    public class _ContactConponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
