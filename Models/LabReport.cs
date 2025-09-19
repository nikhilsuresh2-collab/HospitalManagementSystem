using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class LabReport
    {
        [Key]
        public int ReportId { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public string ReportFile { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }

}
