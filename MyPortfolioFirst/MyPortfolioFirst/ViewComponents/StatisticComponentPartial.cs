using Microsoft.AspNetCore.Mvc;
namespace MyPortfolioFirst.ViewComponents
{
    public class StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
