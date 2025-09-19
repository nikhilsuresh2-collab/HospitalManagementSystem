using Microsoft.EntityFrameworkCore;
namespace HospitalManagementSystem.Models
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<LabReport> LabReports { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<BillingSection> BillingSections { get; set; }
    }
}
