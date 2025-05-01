using GutMeal_Website.Models;
using GutMeal_Website.Services;
using Microsoft.AspNetCore.Mvc;

namespace GutMeal_Website.Controllers
{
    public class GutUserController : Controller
    {
        private static GutUserService _service = new();

        public IActionResult Read()
        {
            var users = _service.GetAll();
            return View("Read", users);
        }
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(GutHealthUser user)
        {
            _service.Add(user);
            return RedirectToAction("Read"); 
        }

        // Edit form
        public IActionResult Edit(int id)
        {
            var user = _service.Get(id);
            return user == null ? NotFound() : View(user);
        }

        [HttpPost]
        public IActionResult Edit(GutHealthUser user)
        {
            _service.Update(user);
            return RedirectToAction("Read");
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Read");
        }
    }
}
