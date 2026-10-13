namespace KurtOtomotiv.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string? Plate { get; set; }
        public string ServiceType { get; set; }
        public DateTime PreferredDate { get; set; }
        public string? Message { get; set; }

    }
}
