using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioFirst.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
