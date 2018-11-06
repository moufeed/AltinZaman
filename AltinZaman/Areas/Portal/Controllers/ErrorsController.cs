using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AltinZaman.Areas.Portal.Controllers
{
    [Area("Portal")]
    [Route("[Area]/[controller]/[Action]")]
    public class ErrorsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        // [Route("NotFound/{msg}")]
        public IActionResult NotFound([FromQuery] string pageName)
        {
            return View();
        }

        [Route("[Controller]/{msg}")]
        public IActionResult Exception(string msg)
        {
            ViewBag.Message = msg;
            return View();
        }
    }
}