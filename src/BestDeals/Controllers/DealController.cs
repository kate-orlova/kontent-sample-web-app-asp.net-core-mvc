using BestDeals.Models.ContentTypes;
using BestDeals.Models.ViewModels;
using Kentico.Kontent.Delivery.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BestDeals.Controllers
{
    public class DealController : ControllerBase
    {
        public DealController(IDeliveryClientFactory deliveryClientFactory) : base(deliveryClientFactory)
        {
        }

        public async Task<ActionResult> Index()
        {
            var itemsTask = _client.GetItemsAsync<Deal>();

            var model = new DealViewModel
            {
                Items = (await itemsTask).Items
            };

            return View(model);
        }

    }
}
