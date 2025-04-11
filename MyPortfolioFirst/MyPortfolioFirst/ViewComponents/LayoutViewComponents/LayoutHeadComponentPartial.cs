using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioFirst.ViewComponents.LayoutViewComponents
{
    public class LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
        
    }
}
