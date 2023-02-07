using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;
using TaxiReportingLoader.Models;

namespace DataAcessLayer.Context
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SystemSettings> SystemSettings { get; set; }
        public DbSet<TransportCoordinator> TransportCoordinators { get; set; }
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
