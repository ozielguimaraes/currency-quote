using System.Threading.Tasks;
using System.Web.Http;

namespace CurrencyQuote.ServerSide.Api.Controllers
{
    [RoutePrefix("v1/currency-quote")]
    public class CurrencyQuoteController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            await Task.Delay(100);

            return Ok();
        }
    }
}