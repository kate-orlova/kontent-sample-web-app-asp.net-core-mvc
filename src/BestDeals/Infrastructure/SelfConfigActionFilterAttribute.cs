using BestDeals.Configuration;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace BestDeals.Infrastructure
{
    public class SelfConfigActionFilterAttribute : ActionFilterAttribute
    {
        public IOptionsSnapshot<AppConfiguration> AppConfig { get; }
        public IOptionsSnapshot<DeliveryOptions> DeliveryOptions { get; }
    }
}
