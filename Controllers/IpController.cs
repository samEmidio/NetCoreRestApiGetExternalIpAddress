
using Microsoft.AspNetCore.Mvc;

namespace NetCoreRestApiGetExternalIpAddress.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IpController : ControllerBase
    {
        //if you run locally .....always returns :: 1
        [HttpGet]
        public ActionResult getExternalIpAddress()
        {
            return Ok(Request.HttpContext.Connection.RemoteIpAddress.ToString());
        }
    }
}

