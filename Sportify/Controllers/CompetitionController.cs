using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sportify.Models;

namespace Sportify.Controllers;

public class CompetitionController: Controller
{
    private readonly ILogger<CompetitionController> _logger;

    public CompetitionController(ILogger<CompetitionController> logger)
    {
        _logger = logger;
    }
    
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
    [Authorize]
    public IActionResult Create()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Back()
    {
        // Redirect to the previous page
        string returnUrl = Request.Headers["Referer"].ToString();
        return Redirect(returnUrl);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}