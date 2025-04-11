using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioFirst.ViewComponents.LayoutViewComponents
{
    public class LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
