using Microsoft.AspNetCore.Mvc;
namespace MyPortfolioFirst.ViewComponents
{
    public class NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
