using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Vezeeta.Core.DTOs.DoctorDTOs
{

    public class AddDoctorRequest
    {
        public string ApplicationUserId { get; set; }
        public string Name { get; set; }
        public int SpecializationId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }

}
