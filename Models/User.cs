using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class User
    {
        [Key]
        [EmailAddress]
        public string Email { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }

        [EnumDataType(typeof(UserRole))]
        public string Role { get; set; }

        public string Contact { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }

    public enum UserRole
    {
        Doctor, Patient, Pharmacist, Labtechnician, Admin, Receptionist
    }

}
