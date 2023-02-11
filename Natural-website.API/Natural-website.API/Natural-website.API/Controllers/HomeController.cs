using Microsoft.AspNetCore.Mvc;
using Natural_website.Application;

namespace Natural_website.API.Controllers
{
    [ApiController]
    [Route("/[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(articleService.GetFirst(10));
        }
    }
}
