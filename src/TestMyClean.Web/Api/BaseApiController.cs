using Microsoft.AspNetCore.Mvc;

namespace TestMyClean.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
