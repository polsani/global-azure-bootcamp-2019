using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Web.Data;
using Task = ToDoList.Web.Models.Task;

namespace ToDoList.Web.Controllers
{
    public class TaskController : Controller
    {
        
        private ApplicationDbContext _context;
        
        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tasks.AsNoTracking().Where(x=>!x.Done).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            task.Id = Guid.NewGuid();
            _context.Tasks.Add(task);
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Task");
        }

        public IActionResult Done(Guid id)
        {
            var task = _context.Tasks.Find(id);
            task.Done = true;
            
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Task");
        }

        public IActionResult Delete(Guid id)
        {
            var task = _context.Tasks.Find(id);
            _context.Tasks.Remove(task);

            _context.SaveChanges();
            return RedirectToAction("Index", "Task");
        }
    }
}