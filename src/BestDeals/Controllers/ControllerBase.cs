using Kentico.Kontent.Delivery.Abstractions;

namespace BestDeals.Controllers
{
    public class ControllerBase
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
