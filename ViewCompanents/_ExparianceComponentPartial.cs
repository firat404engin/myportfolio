using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewCompanents
{
    public class _ExparianceComponentPartial : ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiances.ToList();
            return View(values);
        }
    }
}
