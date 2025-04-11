using Microsoft.AspNetCore.Mvc;
using MyPortfolioFirst.DAL.Context;
using MyPortfolioFirst.DAL.Entities;

namespace MyPortfolioFirst.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IActionResult Index()
        {
            var value=context.toDoLists.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status= false;
            context.toDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var value = context.toDoLists.Find(id);
            context.toDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.toDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.toDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public IActionResult ChangeToDoStatusToFalse(int id)
        {
            var value = context.toDoLists.Find(id);
            value.Status= false;
            return RedirectToAction("Index");
            
        }
        public IActionResult ChangeToDoStatusToTrue(int id)
        {
            var value = context.toDoLists.Find(id);
            value.Status = true;
            return RedirectToAction("Index");

        }

    }
}
