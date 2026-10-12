using Microsoft.AspNetCore.Mvc;

namespace KurtOtomotiv.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
