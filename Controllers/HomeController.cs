using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Models;

namespace Assignment5.Controllers;

public class HomeController : Controller
{
    public IActionResult Homepage()
    {
        return View();
    }
    
    public IActionResult Calculator()
    {
        return View();
    }
    
}
