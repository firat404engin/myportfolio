using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewCompanents
{
    public class _SkillComponentPartial : ViewComponent
   {
       MyPortfolioContext context = new MyPortfolioContext();
            public IViewComponentResult Invoke()
            {
                var values = context.Skillss.ToList();
                return View(values);
            }
        
    }
}