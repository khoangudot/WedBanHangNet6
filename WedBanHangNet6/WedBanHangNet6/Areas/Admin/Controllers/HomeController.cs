using Microsoft.AspNetCore.Mvc;

namespace WedBanHangNet6.Areas.Admin.Controllers
{
    [Area("Admin") ]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
