using KurtOtomotiv.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace KurtOtomotiv.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservationViewModel model)
        {
            if(model.PreferredDate is not null && model.PreferredDate.Value.Date < DateTime.Today)
            {
                ModelState.AddModelError(nameof(model.PreferredDate), "Geçmiş bir tarih seçemezsiniz.");
            }

            if(!ModelState.IsValid)
            {
                return View("Index",model);
            }

            var reservation = new Reservation
            {
                FullName = model.FullName,
                Phone = model.Phone,
                VehicleBrand = model.VehicleBrand,
                VehicleModel = model.VehicleModel,
                Plate = model.Plate,
                ServiceType = model.ServiceType,
                PreferredDate = model.PreferredDate.Value,
                Message = model.Message
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Rezervasyon talebiniz başarıyla kaydedildi.";

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> List()
        {
            var reservations = await _context.Reservations.ToListAsync();

            return View(reservations);
        }
    }
}
