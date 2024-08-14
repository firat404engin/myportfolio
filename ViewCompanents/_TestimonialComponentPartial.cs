using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace MyPortfolio.ViewCompanents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
