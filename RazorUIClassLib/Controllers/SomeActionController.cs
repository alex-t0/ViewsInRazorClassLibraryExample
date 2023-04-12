using Microsoft.AspNetCore.Mvc;

namespace RazorUIClassLib.Controllers;

public class SomeActionController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}