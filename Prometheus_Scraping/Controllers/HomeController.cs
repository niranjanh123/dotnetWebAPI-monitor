using Microsoft.AspNetCore.Mvc;
using Prometheus;

namespace Prometheus_Scraping.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private static readonly Counter RequestCounter = Metrics
            .CreateCounter("hello_requests_total", "Number of hello requests received.");

        [HttpGet(Name = "hello")]
        public string Get()
        {
            RequestCounter.Inc();
            return "Hello, World!";
        }
    }
}
