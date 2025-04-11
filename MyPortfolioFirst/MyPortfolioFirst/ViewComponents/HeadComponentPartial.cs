using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioFirst.ViewComponents


{
    public class HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
        
    }
}
