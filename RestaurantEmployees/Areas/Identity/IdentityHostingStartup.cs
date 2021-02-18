using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(RestaurantEmployees.Areas.Identity.IdentityHostingStartup))]

namespace RestaurantEmployees.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}