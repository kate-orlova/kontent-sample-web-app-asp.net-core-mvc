using BestDeals.Configuration;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace BestDeals.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class SelfConfigActionFilterAttribute : ActionFilterAttribute
    {
        public IOptionsSnapshot<AppConfiguration> AppConfig { get; }
        public IOptionsSnapshot<DeliveryOptions> DeliveryOptions { get; }

        public SelfConfigActionFilterAttribute(IOptionsSnapshot<AppConfiguration> appConfig, IOptionsSnapshot<DeliveryOptions> deliveryOptions)
        {
            AppConfig = appConfig;
            DeliveryOptions = deliveryOptions;
        }
    }
}
