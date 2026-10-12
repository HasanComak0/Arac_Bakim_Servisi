
using System.ComponentModel.DataAnnotations;

namespace KurtOtomotiv.Models
{
    public class ReservationViewModel
    {
        [Required(ErrorMessage ="Ad Soyad Alanı Zorunludur.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Araç markası zorunludur.")]
        public string VehicleBrand { get; set; }

        [Required(ErrorMessage = "Araç modeli zorunludur.")]
        public string VehicleModel { get; set; }

        public string Plate { get; set; }

        [Required(ErrorMessage = "Hizmet türü zorunludur.")]
        public string ServiceType { get; set; }

        public DateTime? PreferredDate { get; set; }

        public string Message { get; set; }
    }
}
