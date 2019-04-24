using System;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Web.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Index()
        {
            throw new Exception("Error accessing the application");
        }
    }
}