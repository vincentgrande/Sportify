using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sportify.Models;

namespace Sportify.Controllers;

public class ScoreboardController: Controller
{
    private readonly ILogger<ScoreboardController> _logger;

    public ScoreboardController(ILogger<ScoreboardController> logger)
    {
        _logger = logger;
    }
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}