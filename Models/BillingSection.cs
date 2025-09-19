using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class BillingSection
    {
        [Key]
        public int BillId { get; set; }

        public int PatientId { get; set; }

        [EnumDataType(typeof(BillType))]
        public string BillType { get; set; }

        [EnumDataType(typeof(PaymentMethod))]
        public string PaymentMethod { get; set; }

        [EnumDataType(typeof(PayStatus))]
        public string PayStatus { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }

    public enum BillType { Lab, Pharmacy, Appointment }
    public enum PaymentMethod { Card, Cash, Upi }
    public enum PayStatus { Paid, Pending, Refunded }

}
