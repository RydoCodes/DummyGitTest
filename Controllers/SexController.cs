using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DummyGitTest.Controllers
{
    public class SexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}