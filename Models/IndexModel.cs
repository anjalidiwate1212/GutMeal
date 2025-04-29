using Microsoft.AspNetCore.Mvc;

namespace GutMeal_Website.Models
{
    public class IndexModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
