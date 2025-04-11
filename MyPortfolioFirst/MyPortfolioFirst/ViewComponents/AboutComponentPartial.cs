using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;
namespace MyPortfolioFirst.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {
       MyPortfolioContext portfoliocontext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=portfoliocontext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfoliocontext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.Detail=portfoliocontext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
