using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;
namespace MyPortfolioFirst.ViewComponents

{
    public class SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= context.Skills.ToList();
            return View(values); 
        }
    }
}
