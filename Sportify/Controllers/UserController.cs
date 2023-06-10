using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sportify.Data.Models;

namespace Sportify.Controllers;

public class ProfileController : Controller
{
    public ProfileController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }
   
}