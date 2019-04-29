using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Web.Controllers
{
    public class ExternalAccessController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://demo-bootcamp-2019-api.azurewebsites.net/api/values");

            return RedirectToAction("Index", "Home");
        }
    }
}