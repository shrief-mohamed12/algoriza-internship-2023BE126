using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain.Models
{
    public class Doctor : BaseEntity
    {
  
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Name { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        //public byte[] DoctorPecture { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
    public enum Gender
    {
        male = 0,
        female = 1
    }
}
