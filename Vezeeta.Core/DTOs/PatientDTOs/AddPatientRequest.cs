namespace Vezeeta.Core.DTOs.PatientDTOs
{
    public class AddPatientRequest
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool AccessFailedCount { get; set; }

    }
}
