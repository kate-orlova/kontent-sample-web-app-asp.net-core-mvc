using BestDeals.Models.ContentTypes;
using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Extensions;
using Kentico.Kontent.Delivery.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BestDeals
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // Enable configuration services
            services.AddOptions();

            // Enable Delivery Client
            services.AddHttpClient<IDeliveryHttpClient, DeliveryHttpClient>();
            services.AddSingleton<ITypeProvider, CustomTypeProvider>();
            services.AddDeliveryClient(Configuration);

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddControllersWithViews();
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
