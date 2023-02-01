using Microsoft.AspNetCore.Mvc;

namespace Natural_website.API.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
