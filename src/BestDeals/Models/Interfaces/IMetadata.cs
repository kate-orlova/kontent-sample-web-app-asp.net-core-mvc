using Kentico.Kontent.Delivery.Abstractions;

namespace BestDeals.Models.Interfaces
{
    public interface IMetadata
    {
        string? MetadataMetaTitle { get; set; }
        string? MetadataMetaDescription { get; set; }
    }
}
