using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;
using MyPortfolioFirst.DAL.Entities;

namespace MyPortfolioFirst.Controllers
{
    public class ExprienceeController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExprienceeList()
        {
            var values = context.Experiencees.ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExpriencee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExpriencee(Experiencee experiencee)
        {
            context.Experiencees.Add(experiencee);
            context.SaveChanges();
            return RedirectToAction("ExprienceeList");
        }
        public IActionResult DeleteExpriencee(int id)
        {
            var value = context.Experiencees.Find(id);
            context.Experiencees.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExprienceeList");
        }
        [HttpGet]

        public IActionResult UpdateExperiencee(int id)
        {
            var value = context.Experiencees.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateExperiencee(Experiencee experiencee)
        {
            context.Experiencees.Update(experiencee);
            context.SaveChanges();
            return RedirectToAction("ExprienceeList");

            //yeni : ExprienceeList
            //eski : ExperienceeList


        }

    }
}


       

