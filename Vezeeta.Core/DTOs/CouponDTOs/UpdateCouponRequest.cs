using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Vezeeta.Core.DTOs.CouponDTOs
{
    public class UpdateCouponRequest
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required, MaxLength(100)]
        public string Description { get; set; }
        public CouponType Type { get; set; }
        [Required]
        public double MinimumAmount { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
