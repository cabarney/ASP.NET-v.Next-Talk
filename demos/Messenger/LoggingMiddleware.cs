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
            await httpContext.Response.WriteAsync("Hi from the middleware!\r\n");
            await httpContext.Response.WriteAsync("This request is a " + httpContext.Request.Method + "\r\n");
        }
	}
}