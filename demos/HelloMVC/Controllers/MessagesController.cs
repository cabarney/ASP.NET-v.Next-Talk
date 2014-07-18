using Demo.Models;
using Microsoft.AspNet.Mvc;

namespace Demo.Controllers
{
	public class MessagesController(IMessageGenerator generator) : Controller
	{
		private IMessageGenerator messageGenerator = generator;

		public IActionResult Hello()
		{
			var message = messageGenerator?.GetMessage();
			return View(message);
		}

		// API
		public IActionResult Get()
		{
			return Json(new { messages = new []{
				new Message {From="One", Text="Message 1"},
				new Message {From="Two", Text="Message 2"},
				new Message {From="Three", Text="Message 3"}
			}});
		}
	}
}