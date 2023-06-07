using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAppBloom.Controllers;
public class HomeController : Controller 
{
    public IActionResult Index()
    {
        return View(); // 3 sobrecargas. 3 formas de passar parametros
    }
}

