using BestDeals.Infrastructure;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Builders.DeliveryClient;
using Microsoft.AspNetCore.Mvc;

namespace BestDeals.Controllers
{
    [TypeFilter(typeof(SelfConfigActionFilterAttribute))]
    public class ControllerBase : Controller
    {
        protected readonly IDeliveryClient _client;
        public ControllerBase()
        {
            _client = DeliveryClientBuilder.WithProjectId("YOUR_PROJECT_ID").Build();
        }
    }
}
