using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }

        public int PatientId { get; set; }

        public string MedicineName { get; set; }
        public int QuantityAvailable { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }

}
