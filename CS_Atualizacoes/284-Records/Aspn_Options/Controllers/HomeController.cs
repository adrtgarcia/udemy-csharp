using Aspn_Options.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aspn_Options.Controllers
{
    public class HomeController : Controller
    {

        private readonly SmtpConfiguration _smtpConfiguration;
        public HomeController(SmtpConfiguration smtpConfiguration)
        {
            _smtpConfiguration = smtpConfiguration;
        }

        public IActionResult Index()
        {
           _smtpConfiguration.Port = 455;

            var domain = _smtpConfiguration.Domain;
            var port = _smtpConfiguration.Port;

            ViewBag.Domain = domain;
            ViewBag.Port = port;

            return View();
        }
    }
}
