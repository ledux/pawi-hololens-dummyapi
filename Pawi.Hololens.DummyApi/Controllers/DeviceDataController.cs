using System.Collections.Generic;
using System.Web.Http;

namespace Pawi.Hololens.DummyApi.Controllers
{
    [RoutePrefix("api")]
    public class DeviceDataController : ApiController
    {
        // GET api/<controller>
        [Route("{device:int}")]
        public IEnumerable<string> Get(int device)
        {
            return new string[] { "value1", "value2" };
        }
    }
}