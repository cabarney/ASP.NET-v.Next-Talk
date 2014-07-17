using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.ConfigurationModel;

namespace Demo
{
	public class Startup
	{
	    public void Configure(IBuilder app)
	    {
	    	var config = new Configuration().AddJsonFile("config.json");
	        app.Run(async context =>
	        {
	        	//var message = "Hello ASP.NET v.Next!";
	        	//var gen = new MessageGenerator();
	        	//var message = gen.GetMessage();
	            var message = config.Get("Message");
	            context.Response.ContentLength = message.Length;
	            await context.Response.WriteAsync(message);
	        });
	    }
	}
}