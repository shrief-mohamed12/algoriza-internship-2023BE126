using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain.Models
{
    public class BookingPocess :BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime TimeofBook { get; set; }
        public DateTime DateOfBook { get; set; }
        public string CouponCode { get; set; }
        public double CouponDiS { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}
