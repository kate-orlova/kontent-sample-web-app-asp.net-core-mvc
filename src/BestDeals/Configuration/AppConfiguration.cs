using Kentico.Kontent.Delivery.Abstractions;

namespace BestDeals.Configuration
{
    public class AppConfiguration
    {
        public string KenticoKontentUrl { get; set; }
        public DeliveryOptions DefaultDeliveryOptions { get; set; }
    }
}
