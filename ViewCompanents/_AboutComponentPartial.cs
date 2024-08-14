using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewCompanents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle= portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.abautSubDescription=portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.abautDetail=portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
