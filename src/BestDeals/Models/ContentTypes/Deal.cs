using BestDeals.Models.Interfaces;
using Kentico.Kontent.Delivery.Abstractions;

namespace BestDeals.Models.ContentTypes
{
    public class Deal : IDeal, IMetadata
    {
        public IContentItemSystemAttributes DealSystemAttributes { get; set; }
        public string? MetadataMetaDescription { get; set; }
        public string? MetadataMetaTitle { get; set; }
        public string Type => DealSystemAttributes.Type;
        public string Id => DealSystemAttributes.Id;
    }
}
