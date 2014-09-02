using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Messenger
{
	public class LoggingMiddleware
	{
		private RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Starting " + httpContext.Request.Path);
            await _next(httpContext);
            Console.WriteLine("Ending " + httpContext.Request.Path);
        }
	}
}