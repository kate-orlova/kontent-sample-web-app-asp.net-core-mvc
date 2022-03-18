using BestDeals.Models.ContentTypes;

namespace BestDeals.Models.ViewModels
{
    public class DealViewModel
    {
        public IEnumerable<Deal> Items { get; set; } = new List<Deal>();
    }
}
