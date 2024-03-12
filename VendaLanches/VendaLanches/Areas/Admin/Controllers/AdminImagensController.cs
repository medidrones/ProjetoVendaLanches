using Microsoft.AspNetCore.Mvc;

namespace VendaLanches.Areas.Admin.Controllers
{
    public class AdminImagensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
