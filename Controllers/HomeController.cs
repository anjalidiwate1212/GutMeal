using Microsoft.AspNetCore.Mvc;
using GutMeal_Website.Models;
using System.Diagnostics;

namespace GutMeal_Website.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new IndexModel();
        // Populate model if needed
        return View(model);
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Charts()
    {
        return View();
    }

    public IActionResult Create()
    {
        // Show empty form
        return View(new UserDetails());
    }

    [HttpPost]
    public IActionResult Create(UserDetails userDetails)
    {
        if (!ModelState.IsValid)
        {
            // If validation fails, redisplay form with current data
            return View(userDetails);
        }
        // TODO: Save or process the userDetails as needed

        // Redirect to meal plans page after submission (placeholder)
        return RedirectToAction("ExploreMealPlans");
    }

    public IActionResult Delete()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }

    public IActionResult ExploreMealPlans()
    {
        return View();
    }

    public IActionResult Read()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
