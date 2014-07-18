using Microsoft.AspNet.Mvc;

namespace Demo.Controllers
{
	public class HomeController
	{
		public IActionResult Index()
		{
			return new ContentResult{Content="Hello MVC!"};
		}
	}
}