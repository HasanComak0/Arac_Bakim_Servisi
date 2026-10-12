using KurtOtomotiv.Models;
using Microsoft.AspNetCore.Mvc;

namespace KurtOtomotiv.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var services = new List<ServiceViewModel>
            {
                new ServiceViewModel
                {
                    Id = 1,
                    Title = "Oto Servis",
                    ShortDescription = "Aracınızın mekanik bakım ve onarım işlemleri.",
                    Description = "Aracınızın mekanik sistemlerinde meydana gelebilecek sorunların tespiti, bakım ve onarım işlemlerini profesyonel şekilde gerçekleştiriyoruz.",
                    ImageUrl = "/images/service-detail.jpg",

                    Features = new List<string>
                    {
                        "Mekanik bakım ve onarım",
                        "Genel araç kontrolü",
                        "Arıza tespiti",
                        "Periyodik kontroller"
                    }
                },

                new ServiceViewModel
                {
                    Id = 2,
                    Title = "Araç Bakımı",
                    ShortDescription = "Aracınızın düzenli bakım ve kontrolleri.",
                    Description = "Aracınızın performansını ve güvenliğini korumak için gerekli periyodik bakım ve genel kontrol işlemlerini gerçekleştiriyoruz.",

                    ImageUrl = "/images/car-maintenance.jpg",

                    Features = new List<string>
                    {
                        "Periyodik bakım",
                        "Motor yağı kontrolü",
                        "Filtre kontrolleri",
                        "Fren ve lastik kontrolleri"
                    }
                }
            };

            var service = services.FirstOrDefault(x => x.Id == id);

            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }
    }
}