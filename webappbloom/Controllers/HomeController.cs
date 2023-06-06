using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace webappbloom.Controllers;
public class HomeController : Controller 
{
    public IActionResult Index()
    {
        return View(); // 3 sobrecargas. 3 formas de passar parametros
    }
}

