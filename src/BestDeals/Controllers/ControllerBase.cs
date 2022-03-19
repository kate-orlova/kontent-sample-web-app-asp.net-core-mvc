using BestDeals.Infrastructure;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BestDeals.Controllers
{
    [TypeFilter(typeof(SelfConfigActionFilterAttribute))]
    public class ControllerBase : Controller
    {
        protected readonly IDeliveryClient _client;
        public ControllerBase(IDeliveryClientFactory deliveryClientFactory) : this()
        {
            _client = deliveryClientFactory.Get();
        }

        public ControllerBase()
        {

        }
    }
}
