using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Web.Controllers
{
    public class MemoryLeakController : Controller
    {
        private List<byte[]> listMemoryLeak = new List<byte[]>();

        public async Task<IActionResult> Index()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    listMemoryLeak.Add(new byte[4096]);
                    Thread.Sleep(1);
                }
            });
            
            return RedirectToAction("Index", "Home");
        }
    }
}