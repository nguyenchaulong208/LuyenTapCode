using Microsoft.AspNetCore.Mvc;

namespace APIs_Example.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
