using Microsoft.AspNetCore.Mvc;

namespace sage_bushstone_versioncontrol.Controllers
{
    public class NameController : Controller
    {
        public string JsonName()
        {
            return "{[\"Sage Bushstone\"]}";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
