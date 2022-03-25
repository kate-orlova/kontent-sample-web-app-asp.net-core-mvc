using BestDeals.Models.ContentTypes;
using BestDeals.Models.ViewModels;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters.Filters;
using Microsoft.AspNetCore.Mvc;

namespace BestDeals.Controllers
{
    public class DealsController : ControllerBase
    {
        public async Task<ActionResult> Index()
        {
            var parameters = new List<IQueryParameter>()
            {
                new EqualsFilter("system.type", "offer")
            };

            var response = await _client.GetItemsAsync<Deal>(parameters);
            var model = new DealsViewModel
            {
                Items = response.Items
            };

            return View(model);
        }
    }
}
