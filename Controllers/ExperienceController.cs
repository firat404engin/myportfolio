using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiances.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience() 
        { 

         return View();

        }
        [HttpPost]

		public IActionResult CreateExperience(Experiance experiance)
		{

			context.Experiances.Add(experiance);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

		}

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiances.Find(id);
            context.Experiances.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiances.Find(id);
            return View(value);
        }
        [HttpPost]
		public IActionResult UpdateExperience(Experiance   experiance)
		{
			context.Experiances.Update(experiance);
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

	}
}
