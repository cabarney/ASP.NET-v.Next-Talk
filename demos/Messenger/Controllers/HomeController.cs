using Microsoft.AspNet.Mvc;
using Messenger.Web.Models;

namespace Messenger
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}