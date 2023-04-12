using Microsoft.AspNetCore.Mvc;

namespace RazorUIClassLib.Controllers;

public class SomeOtherActionController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}