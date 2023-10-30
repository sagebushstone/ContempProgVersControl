using Microsoft.AspNetCore.Mvc;

namespace sage_bushstone_versioncontrol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult DisplayName()
        {
            string name = "Sage Bushstone";
            return new JsonResult(new {Name = name});
        }
    }
}
