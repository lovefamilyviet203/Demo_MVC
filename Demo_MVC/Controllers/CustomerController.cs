using Microsoft.AspNetCore.Mvc;

namespace Demo_MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Customer()
        {
            return View();
        }
    }
}
