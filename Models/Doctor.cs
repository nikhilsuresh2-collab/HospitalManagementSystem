using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string Email { get; set; }

        public string Specialization { get; set; }

        [ForeignKey("Email")]
        public User User { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<LabReport> LabReports { get; set; }
    }

}
