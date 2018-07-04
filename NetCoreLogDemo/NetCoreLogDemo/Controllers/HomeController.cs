using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NetCoreLogDemo.Models;

namespace NetCoreLogDemo.Controllers
{
    public class HomeController : Controller
    {
        private ILog log;

        public HomeController(IHostingEnvironment hostingEnv)
        {
            this.log = LogManager.GetLogger(Startup.repository.Name, typeof(HomeController));
        }

        public IActionResult Index()
        {
            log.Error("测试日志");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
