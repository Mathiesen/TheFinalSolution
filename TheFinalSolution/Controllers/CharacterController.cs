using Microsoft.AspNetCore.Mvc;

namespace TheFinalSolution.Controllers;

public class CharacterController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}