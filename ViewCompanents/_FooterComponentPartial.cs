using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyPortfolio.ViewCompanents
{
    public class _FooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           return View();
        }
    }
}
