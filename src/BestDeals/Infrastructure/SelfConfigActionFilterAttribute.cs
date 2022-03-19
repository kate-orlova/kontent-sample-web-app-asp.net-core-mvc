using BestDeals.Configuration;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;

namespace BestDeals.Infrastructure
{
    public class SelfConfigActionFilterAttribute : ActionFilterAttribute
    {
        public IOptionsSnapshot<AppConfiguration> AppConfig { get; }
    }
}
