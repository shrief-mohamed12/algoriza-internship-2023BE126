using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vezeeta.Domain.Models
{
    public class Coupon : BaseEntity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public CouponType Type { get; set; }
        public double MinimumAmount { get; set; }
        public byte[] CouponPecture { get; set; }
        public bool IsActive { get; set; }
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CouponType
    {
        Perecent = 0,
        Currency = 1
    }
}
