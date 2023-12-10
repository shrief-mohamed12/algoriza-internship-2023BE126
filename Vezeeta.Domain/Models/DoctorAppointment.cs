using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vezeeta.Domain.Models
{
    public class DoctorAppointment : BaseEntity
    {
      
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
       // public List<days> dayOfWeeks { get; set; }
    }
   // [JsonConverter(typeof(StringEnumConverter))]
    public enum days
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }
}
