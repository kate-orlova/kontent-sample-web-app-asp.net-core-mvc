using BestDeals.Models.Interfaces;
using Kentico.Kontent.Delivery.Abstractions;

namespace BestDeals.Models.ContentTypes
{
    public class Deal : IDeal, IMetadata
    {
        public const string Codename = "offer";
        public const string TitleCodename = "title";
        public const string MarketingTitleCodename = "offer_marketing_details__short_name";
        public const string MarketingHeadlineCodename = "offer_marketing_details__headline";

        public IContentItemSystemAttributes DealSystemAttributes { get; set; }
        public string? MetadataMetaDescription { get; set; }
        public string? MetadataMetaTitle { get; set; }
        public string Type => DealSystemAttributes.Type;
        public string Id => DealSystemAttributes.Id;
        public string Title { get; set; }
        public string MarketingTitle { get; set; }
        public string MarketingHeadline { get; set; }
    }
}
