using Vezeeta.Domain;
using Vezeeta.Domain.Models;

namespace Vezeeta.Core.DTOs.DoctorDTOs
{
    public class DoctorDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Specialization Specialization { get; set; }
    }
}
