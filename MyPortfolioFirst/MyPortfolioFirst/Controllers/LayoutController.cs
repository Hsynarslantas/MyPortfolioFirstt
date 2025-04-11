using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioFirst.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
