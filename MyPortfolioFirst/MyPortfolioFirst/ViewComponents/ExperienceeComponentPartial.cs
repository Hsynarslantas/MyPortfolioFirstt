using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;
namespace MyPortfolioFirst.ViewComponents
{
    public class ExperienceeComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiencees.ToList();
            return View(values);

        }
    }
}
