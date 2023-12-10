using System.Text.Json.Serialization;

namespace Vezeeta.Core.DTOs.CouponDTOs
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CouponType
    {
        Perecent = 0,
        Currency = 1
    }

}
