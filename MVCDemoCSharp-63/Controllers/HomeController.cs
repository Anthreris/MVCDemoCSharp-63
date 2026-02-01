using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDemoCSharp_63.Models;

namespace MVCDemoCSharp_63.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var names = new List<string>() { "Garrett", "Seth", "Miah", "Cynthia" };
        return View(names);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}