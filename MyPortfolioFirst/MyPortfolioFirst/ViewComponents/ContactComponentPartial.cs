using Microsoft.AspNetCore.Mvc;
namespace MyPortfolioFirst.ViewComponents
{
    public class ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
