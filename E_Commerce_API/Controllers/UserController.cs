using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
