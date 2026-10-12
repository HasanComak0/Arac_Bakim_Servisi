using KurtOtomotiv.Models;
using Microsoft.AspNetCore.Mvc;

namespace KurtOtomotiv.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ReservationViewModel model)
        {
            if(model.PreferredDate is not null && model.PreferredDate.Value.Date < DateTime.Today)
            {
                ModelState.AddModelError(nameof(model.PreferredDate), "Geçmiş bir tarih seçemezsiniz.");
            }

            if(!ModelState.IsValid)
            {
                return View("Index",model);
            }
            return Content(model.FullName);
        }
    }
}
