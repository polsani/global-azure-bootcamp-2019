using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            
            var randonNumber = new Random().Next(1,1000);

            if(randonNumber % 5 == 0)
            {
                Thread.Sleep(10000);
            }

            return Ok();
        }
    }
}
