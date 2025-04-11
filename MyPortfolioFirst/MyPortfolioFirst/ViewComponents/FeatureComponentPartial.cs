using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;
namespace MyPortfolioFirst.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
