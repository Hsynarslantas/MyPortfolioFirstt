using Microsoft.AspNetCore.Mvc;
namespace MyPortfolioFirst.ViewComponents
{
    public class TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
