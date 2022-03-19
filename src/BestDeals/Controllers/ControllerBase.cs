using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BestDeals.Controllers
{
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
