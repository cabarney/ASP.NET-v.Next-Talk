using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Data.Entity;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.ConfigurationModel;
using Messenger.Models;

namespace Messenger
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            var configuration = new Configuration();
            configuration.AddJsonFile("localconfig.json");


            app.UseStaticFiles();
            app.UseErrorPage();


            app.UseServices(services =>
            {
                services.AddEntityFramework().AddSqlServer();

                services.AddScoped<MessengerDataContext>();

                services.SetupOptions<MessengerDbContextOptions>(options =>
                    {
                        options.UseSqlServer(configuration.Get("Data:DefaultConnection:ConnectionString"));
                    });

                services.AddMvc();
            });

            app.UseMvc();

            app.UseWelcomePage();
        }       
    }
}
