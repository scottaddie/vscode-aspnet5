using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace vscode_aspnet5.Controllers
{
    public class ConferenceController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "Your conference page.";
            return View();
        }
    }
}
