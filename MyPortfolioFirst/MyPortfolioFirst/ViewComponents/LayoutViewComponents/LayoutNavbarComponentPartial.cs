using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;

namespace MyPortfolioFirst.ViewComponents.LayoutViewComponents
{
    public class LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.toDoLists.Where(x=>x.Status==false).Count();
            var values = context.toDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
