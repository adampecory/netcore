using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace netcore.Controllers
{
  public class HomeController : Controller
  {
      /* 
     ILogger<ControllerNameController> _logger;

    public ControllerNameController(ILogger<ControllerNameController> logger)
    {
      _logger = logger;
    }
*/
    public IActionResult Index()
    {
      
      return View();
    }
  }
}