using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BibliotecaMVC.Controllers
{
    [Route("[controller]")]
    public class OperaçõesController : Controller
    {
        private readonly ILogger<OperaçõesController> _logger;

        public OperaçõesController(ILogger<OperaçõesController> logger)
        {
            _logger = logger;
        }
        public string Index() 
        { 
            return "This is my <b>default</b> actiondddd..."; 
        } 
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}