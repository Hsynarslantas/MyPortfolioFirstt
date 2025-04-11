using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioFirst.ViewComponents.LayoutViewComponents
{
    public class LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
