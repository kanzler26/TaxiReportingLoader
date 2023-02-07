using DataAcessLayer.Models;

namespace TaxiReportingLoader.Models
{
    public class Ride
    {
        public int RideId { get; set; }
        public int Month { get; set; }
        public int FullYear { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime Start { get; set; }
        public string? AdressFrom { get; set; }
        public string? AdressTo { get; set; }
        public decimal PriceWithoutTax { get; set; }
        public decimal Tax { get; set; }
        public Report? Report { get; set; }
    }
}
