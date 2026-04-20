using Microsoft.EntityFrameworkCore;
using PAA_LKM1.Models;

namespace PAA_LKM1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pasien> Pasien { get; set; }
        public DbSet<Dokter> Dokter { get; set; }
        public DbSet<Perawatan> Perawatan { get; set; }
    }
}