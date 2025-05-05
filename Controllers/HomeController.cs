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

    public IActionResult Charts(string meal)
    {
        if (!string.IsNullOrEmpty(meal))
        {
            // Pass meal plan info to the view via ViewBag
            ViewBag.MealPlan = meal;

            // Define default foods based on meal plan
            ViewBag.DefaultFoods = GetDefaultFoodsForMealPlan(meal);
        }

        return View();
    }

    private Dictionary<string, List<string>> GetDefaultFoodsForMealPlan(string mealPlan)
    {
        // Define default foods for each meal plan
        var mealPlanFoods = new Dictionary<string, List<string>>
        {
            ["Keto-Friendly Low-Sugar Plan"] = new List<string> { "avocado", "salmon", "spinach" },
            ["Gut-Health Fiber Boost"] = new List<string> { "lentils", "oats", "apples" },
            ["Mediterranean Gut Balance"] = new List<string> { "olive oil", "tomatoes", "fish" },
            ["Metabolic Maintenance Diet"] = new List<string> { "chicken breast", "brown rice", "broccoli" },
            ["Dairy-Free Anti-Inflammation Plan"] = new List<string> { "tofu", "quinoa", "blueberries" },
            ["Digestive Relief (Low-FODMAP)"] = new List<string> { "eggs", "rice", "kale" },
            ["Heart Health Plus"] = new List<string> { "walnuts", "flaxseed", "berries" }
        };

        // Return default foods for the specified meal plan, or a generic default if not found
        return mealPlanFoods.TryGetValue(mealPlan, out var foods)
            ? new Dictionary<string, List<string>> { ["foods"] = foods }
            : new Dictionary<string, List<string>> { ["foods"] = new List<string> { "apple", "chicken", "broccoli" } };
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


