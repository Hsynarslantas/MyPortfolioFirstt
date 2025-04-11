using Microsoft.AspNetCore.Mvc;
namespace MyPortfolioFirst.ViewComponents
{
    public class PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
