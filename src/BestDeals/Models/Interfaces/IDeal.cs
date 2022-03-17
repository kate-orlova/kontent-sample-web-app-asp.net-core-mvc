using Kentico.Kontent.Delivery.Abstractions;

namespace BestDeals.Models.Interfaces
{
    public interface IDeal
    {
        IContentItemSystemAttributes DealSystemAttributes { get; set; }
    }
}
