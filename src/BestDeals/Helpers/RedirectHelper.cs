using BestDeals.Models;
using Microsoft.AspNetCore.Mvc;

namespace BestDeals.Helpers
{
    public static class RedirectHelper
    {
        public static RedirectToRouteResult GetSelfConfigIndexResult(MessageModel message)
        {
            return new RedirectToRouteResult(new RouteValueDictionary(new
            {
                Action = "Index",
                Controller = "SelfConfig",
                Area = "Admin",
                MessageBody = message?.Message,
                message?.MessageType
            }));
        }
    }
}
