using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Demo.Models;

namespace WebApplication3
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseErrorPage();

            app.UseServices(services =>
            {
                services.AddMvc();

                services.AddScoped<IMessageGenerator, MessageGenerator>();
            });

            app.UseMvc();

            app.UseWelcomePage();
        }
    }
}
