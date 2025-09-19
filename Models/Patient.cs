using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [ForeignKey("Email")]
        public User User { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<LabReport> LabReports { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public ICollection<BillingSection> Bills { get; set; }
    }

}
