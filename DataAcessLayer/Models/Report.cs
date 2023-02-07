using TaxiReportingLoader.Models;

namespace DataAcessLayer.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int Month { get; set; }
        public int FullYear { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public bool Status { get; set; }
        public List<Ride>? Rides { get; set; }
    }
}
